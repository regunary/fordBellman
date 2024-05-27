using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DrawMatrix : Form
    {
        public DrawMatrix()
        {
            InitializeComponent();
            bm = new Bitmap(this.printPicture.Width, this.printPicture.Height); //tạo 1 cái bm để hiển thị ảnh theo kích thước của khung picturebox màu đen tên là "printPicture"
            graph = Graphics.FromImage(bm); //dùng graphics để chỉnh sửa rồi hiện thị lên picturebox

        }

        /********************************************************************************************
        * 
        *       TẠO CÁC BIẾN THEO CLASS
        * 
        ********************************************************************************************/

        Graphics graph;
        Draw draw;
        Matrix matrix;
        Vertex vertex;
        Bitmap bm;
        Check check;

        //Vertex choseVertex; //biến này dùng để lưu đỉnh được chọn khi click vào 1 đỉnh trên đồ thị
        //Edge choseEdge; //biến này dùng để lưu cạnh được chọn khi click vào 1 đỉnh trên đồ thị.
        public bool mouseLeft = true; //BIẾN KIỂM TRA XEM BẠN ĐÃ "THẢ" CHUỘT RA CHƯA HAY VẪN CÒN NHẤP GIỮ CHUỘT.

        private void DrawMatrix_Load(object sender, EventArgs e) //hiển thị lên màn hình
        {
            this.Text = "Ma Trận"; //đặt tên của client là "ma trận"
            cbDHeadVertex.Enabled = cbDTailVertex.Enabled = dShowMatrix.Enabled = true; //bật hiển thị 2 đỉnh và khung ma trận trọng số

            /********************************************************************************************
            * 
            *       HIỂN THỊ MA TRẬN TRỌNG SỐ LÊN "dShowMatrix"
            * 
            ********************************************************************************************/
            for (int i = 0; i < Graph.vertexNumber; i++)
            {
                cbDHeadVertex.Items.Add(i); //thêm số vô đỉnh xuất phát
                cbDTailVertex.Items.Add(i); //thêm số vô đỉnh kết thúc
            }

            dShowMatrix.Rows.Clear(); //xóa hàng cho bảng matrix
            dShowMatrix.Columns.Clear(); //xóa cột cho bảng matrix

            int width = dShowMatrix.Width / Graph.vertexNumber; //tạo biến chiều rộng để chia đều hàng
            int height = dShowMatrix.Height / Graph.vertexNumber; //tạo biến chiều cao để chia đều cột

            for (int i = 0; i < Graph.vertexNumber; i++)
            {
                dShowMatrix.Columns.Add((i).ToString(), (i).ToString()); //thêm cột
                dShowMatrix.Columns[i].Width = width; //cân bằng với chiều rộng khuôn hình

            }

            for (int i = 0; i < Graph.vertexNumber; i++)
            {
                dShowMatrix.Rows.Add(); //thêm hàng
                dShowMatrix.Rows[i].Height = height; //cân bằng với chiều cao khung hình

                for (int j = 0; j < Graph.vertexNumber; j++)
                {
                    dShowMatrix[j, i].Value = Graph.matrix[i, j]; //ma trận lúc này được lưu từ Graph matrix nên sẽ in ra
                }
            }

            /********************************************************************************************
            * 
            *       HIỂN THỊ ĐỒ THỊ LÊN KHUNG PICTUREBOX
            * 
            ********************************************************************************************/
            matrix = new Matrix();
            matrix.inputMatrixFromGRAPHClass();
            graph.Clear(Color.Black);
            draw = new Draw(matrix);
            draw.drawGraph(matrix._iMatrix, matrix._iNMatrix, graph);
            printPicture.Image = bm;
            printPicture.Show();
            printPicture.Enabled = true;

        }

        //tạo sự kiện di chuyển chuột
        private void printPicture_MouseMove(object sender, MouseEventArgs e) 
        {
            if (draw != null)
            {
                if (e.Button == MouseButtons.None)
                {
                    draw.resetUsingPoint(); //xóa toàn bộ các điểm hoạt động của chuột trên hình vẽ
                    mouseLeft = false; //tắt chuột trái
                }
                else if (e.Button == MouseButtons.Left && e.X >= 0 && e.Y >= 0 && (e.X <= printPicture.Width) && (e.Y <= printPicture.Height)) //event chuột trái chỉ được phép nằm trong khung printPicture
                {
                    draw.Drag(e.Location, e, matrix, graph); //dùng drag để vẽ lại các vị trí của event
                    mouseLeft = true;
                    printPicture.Image = bm;
                    printPicture.Show(); //gán ra màn hình
                }
                if (mouseLeft) //nếu mouseLeft = true
                {
                    printPicture.Image = bm;
                    printPicture.Show(); //hiển thị ra
                }
            }
        }

        //viết hàm để bắt sự kiện click chuột (để đơn giản bớt nên nhóm sẽ tắt chức năng này)
        private void printPicture_MouseClick(object sender, MouseEventArgs e)
        {
            //foreach (Vertex vertex in draw._vVertex) //dùng vòng lặp foreach
            //{
            //    if (vertex.isMouseOnVertex(e.Location)) //kiểm tra nếu chuột click vào đỉnh
            //    {
            //        graph.Clear(Color.Black); //xóa hình vẽ đi
            //        draw.drawGraph(matrix._iMatrix, matrix._iNMatrix, graph); //vẽ lại đồ thị
            //        printPicture.Image = bm;

            //        choseVertex = vertex; //đỉnh lúc này đã được chọn
            //    }

            //}

            //foreach (Edge edge in draw._eEdge) //tiếp tục xét cạnh
            //{
            //    if (edge == null)
            //        continue;

            //    else if (edge.isMouseOnEdge(e.X, e.Y)) //nếu kiểm tra chuột trỏ tới cạnh
            //    {
            //        graph.Clear(Color.Black);
            //        draw.drawGraph(matrix._iMatrix, matrix._iNMatrix, graph); //vẽ lại đồ thị
            //        printPicture.Image = bm;

            //        if (edge._vHead._isDel == 0 && edge._vTail._isDel == 0) //sau đó mới vẽ cạnh được chọn vào
            //        {
            //            draw.drawChoseEdge(graph, edge._vHead._iVerNum, edge._vTail._iVerNum, matrix); //(graphics, cạnh.đỉnh đầu.số trên đỉnh, cạnh.đỉnh cuối.số trên đỉnh, ma trận)
            //            draw.drawVertex(graph, edge._vHead);
            //            draw.drawVertex(graph, edge._vTail);
            //            printPicture.Image = bm;
            //        }

            //        choseEdge = edge;
            //    }

            //    else if (edge.isMouseOnEdge(e.X, e.Y) == false) //nếu chuột không trỏ tới cạnh
            //    {
            //        graph.Clear(Color.Black);
            //        draw.drawGraph(matrix._iMatrix, matrix._iNMatrix, graph); //thì chỉ vẽ ma trận với các điểm đã lưu, số đỉnh
            //        printPicture.Image = bm;
            //        choseEdge = null;
            //    }
            //}
        }
        private void start_Click(object sender, EventArgs e)
        {

            graph.Clear(Color.Black);
            draw.drawGraph(matrix._iMatrix, matrix._iNMatrix, graph);
            printPicture.Image = bm;
            check = new Check(matrix);
            check.checkingConnection(matrix, draw, graph, bm, this);
            Thread.Sleep(500);
            BellmanFord FB = new BellmanFord(Graph.vertexNumber, Graph.matrix);
            int head = Convert.ToInt32(cbDHeadVertex.Text); //tạo biến nhận điểm đầu từ combobox
            int tail = Convert.ToInt32(cbDTailVertex.Text); //tạo biến nhận điểm cuối từ combobox
            FB.FordBellman(matrix, rtbLog, head, tail, graph, draw, bm, vertex, this);
            MessageBox.Show("Đã duyệt xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
