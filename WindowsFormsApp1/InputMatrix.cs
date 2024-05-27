using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{
    public partial class InputMatrix : Form
    {
        public InputMatrix()
        {
            InitializeComponent();

        }

        private void InputMatrix_Load(object sender, EventArgs e) //màn hình hiển thị của inputMatrix sẽ ẩn trọng số, đỉnh xuất phát, đỉnh kết thúc, ẩn hiển thị ma trận
        {
            this.Text = "Nhập ma trận";
            cbHeadVertex.Enabled = cbTailVertex.Enabled = tbWeight.Enabled = showMatrix.Enabled = printLine.Enabled = false;

        }

        public int vertexNumber; //tạo biến nhận số đỉnh
        public int[,] matrix; //tạo ma trận 2 chiều
        private void fromInput_Click(object sender, EventArgs e) //hàm của nút Nhập số đỉnh
        {
            try
            {
                int.TryParse(tbInputVertices.Text, out vertexNumber); //tạo phương thức để chuyển chuỗi sang kiểu int (chuỗi nhập vào, xuất ra biến chứa)
                if (vertexNumber <= 1)
                {
                    showMatrix.Rows.Clear(); //xóa hàng cho bảng matrix
                    showMatrix.Columns.Clear(); //xóa cột cho bảng matrix
                    MessageBox.Show("Bạn phải nhập từ 2 đỉnh trở lên !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (vertexNumber > 10)
                {
                    showMatrix.Rows.Clear(); //xóa hàng cho bảng matrix
                    showMatrix.Columns.Clear(); //xóa cột cho bảng matrix
                    MessageBox.Show("Bạn chỉ được nhập tối đa 10 đỉnh !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    matrix = new int[vertexNumber, vertexNumber]; //nhập dữ liệu cho mảng 2 chiều
                    cbHeadVertex.Enabled = cbTailVertex.Enabled = tbWeight.Enabled = showMatrix.Enabled = true; //hiện nút

                    cbHeadVertex.Items.Clear(); //xóa combobox
                    cbTailVertex.Items.Clear(); //xóa combobox

                    for (int i = 0; i < vertexNumber; i++)
                    {
                        cbHeadVertex.Items.Add(i); //thêm số vô đỉnh xuất phát
                        cbTailVertex.Items.Add(i); //thêm số vô đỉnh kết thúc
                    }

                    toListView(); //chạy hàm tolistview
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void toListView()
        {
            cbHeadVertex.Enabled = cbTailVertex.Enabled = true; //đỉnh bắt đầu và đỉnh kết thúc sẽ hiện nếu số đỉnh đã được biết
            addMove.Enabled = randomMatrix.Enabled = printLine.Enabled = true; //hiện nút thêm và nút random
            showMatrix.Rows.Clear(); //xóa hàng cho bảng matrix
            showMatrix.Columns.Clear(); //xóa cột cho bảng matrix

            int width = showMatrix.Width / vertexNumber; //tạo biến chiều rộng để chia đều hàng
            int height = showMatrix.Height / vertexNumber; //tạo biến chiều cao để chia đều cột

            for (int i = 0; i < vertexNumber; i++)
            {
                showMatrix.Columns.Add((i + 1).ToString(), (i + 1).ToString()); //thêm cột
                showMatrix.Columns[i].Width = width; //cân bằng với chiều rộng khuôn hình

            }

            for (int i = 0; i < vertexNumber; i++)
            {
                showMatrix.Rows.Add(); //thêm hàng
                showMatrix.Rows[i].Height = height; //cân bằng với chiều cao khung hình

                for (int j = 0; j < vertexNumber; j++)
                {
                    if (matrix[i, j] == 0 && i != j)
                    {
                        showMatrix[j, i].Value = "∞"; //nếu khác đường chéo chính thì in vô cùng ra
                    }
                    else
                        showMatrix[j, i].Value = matrix[i, j]; //ma trận lúc này có giá trị là 0 nên sẽ tạo trên đường chéo chính
                }
            }
        }

        //hàm random số trên ma trận
        private void randomMatrix_Click(object sender, EventArgs e)
        {
            Random rand = new Random(); //tạo biến random là rand
            int[,] checkpoint = new int[vertexNumber, vertexNumber]; //tạo biến ma trận 2 chiều để đánh dấu

            for (int i = 0; i < vertexNumber; i++)
            {
                for (int j = 0; j < vertexNumber; j++)
                {

                    if (i != j && checkpoint[i, j] == 0) //nếu đánh dấu ma trận = 0 thì random số
                    {
                        matrix[i, j] = matrix[j, i] = rand.Next(10);
                        checkpoint[i, j] = checkpoint[j, i] = 1;
                    }
                }
            }
            toListView();
        }

        private void addMove_Click(object sender, EventArgs e) //thêm trọng số bằng tay vô các đỉnh
        {
            int headVertex = int.Parse(cbHeadVertex.Text); //chuyển kiểu từ text sang in bằng Parse gán vô biến đầu
            int tailVertex = int.Parse(cbTailVertex.Text); //chuyển kiểu từ text sang in bằng Parse gán vô biến cuối
            int weight = int.Parse(tbWeight.Text); //chuyển kiểu từ text sang in bằng Parse gán vô biến trọng số
            if (headVertex == tailVertex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
            else
                matrix[headVertex - 1, tailVertex - 1] = matrix[tailVertex - 1, headVertex - 1] = weight;

            toListView();

        }
        //nhấp vô nút hoàn tất sẽ thực hiện hàm này
        private void printLine_Click(object sender, EventArgs e)
        {

            Graph.matrix = matrix;
            Graph.vertexNumber = vertexNumber;

            DrawMatrix dM = new DrawMatrix();
            dM.Show();
            this.Close();
        }

        //hàm xuất ma trận từ file
        void showMatrixFromFile()
        {
            tbInputVertices.Text = vertexNumber.ToString();
            printLine.Enabled = true;
            fromInput.Enabled = tbInputVertices.Enabled = tbWeight.Enabled = addMove.Enabled = randomMatrix.Enabled = cbHeadVertex.Enabled = cbTailVertex.Enabled = false;


            cbHeadVertex.Items.Clear(); //nếu nhập từ file thì xóa combobox để nhận đỉnh đầu
            cbTailVertex.Items.Clear(); //nếu nhập từ file thì xóa combobox để nhận đỉnh cuối

            for (int i = 0; i < vertexNumber; i++)
            {
                cbHeadVertex.Items.Add(i); //thêm số vô đỉnh xuất phát
                cbTailVertex.Items.Add(i); //thêm số vô đỉnh kết thúc
            }

            showMatrix.Rows.Clear(); //xóa hàng cho bảng matrix
            showMatrix.Columns.Clear(); //xóa cột cho bảng matrix

            int width = showMatrix.Width / vertexNumber; //tạo biến chiều rộng để chia đều hàng
            int height = showMatrix.Height / vertexNumber; //tạo biến chiều cao để chia đều cột

            for (int i = 0; i < vertexNumber; i++)
            {
                showMatrix.Columns.Add((i).ToString(), (i).ToString()); //thêm cột
                showMatrix.Columns[i].Width = width; //cân bằng với chiều rộng khuôn hình

            }

            for (int i = 0; i < vertexNumber; i++)
            {
                showMatrix.Rows.Add(); //thêm hàng
                showMatrix.Rows[i].Height = height; //cân bằng với chiều cao khung hình

                for (int j = 0; j < vertexNumber; j++)
                {
                    showMatrix[j, i].Value = matrix[i, j]; //ma trận lúc này được lưu từ matrix nên sẽ in ra
                }
            }
        }

        //hàm nhập ma trận từ tệp trong strip
        private void nhậpMaTrậnTừTệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog(); //hàm mở file
            OD.InitialDirectory = Application.StartupPath;
            OD.Filter = "Text File|*.txt";
            OD.Title = "Chọn file"; //đặt title
            if (OD.ShowDialog() == DialogResult.OK && OD.FileName != "")
            {
                Matrix matrixF = new Matrix();
                matrixF.inputMatrixFromFile(OD.FileName);
                for (int i = 0; i < matrixF._iNMatrix; i++)
                    for (int j = 0; j < matrixF._iNMatrix; j++)
                    {
                        if (matrixF._iMatrix[i, j] != matrixF._iMatrix[j, i])
                        {
                            MessageBox.Show("Ma trận không đúng, vui lòng chọn lại ma trận khác!");
                            return;
                        }
                    }
                matrix = matrixF._iMatrix;
                vertexNumber = matrixF._iNMatrix;
            }
            showMatrixFromFile();

        }

        //lưu ma trận ra tệp
        private void lưuMaTrậnRaTệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"MTTS.txt";
            FileStream f = new FileStream(path, FileMode.Create); //chế độ tạo tệp
            StreamWriter sw = new StreamWriter(f); //dùng streamwriter để in ra tệp
            if (matrix != null)
            {
                sw.WriteLine(vertexNumber.ToString());
                for (int i = 0; i < vertexNumber; i++)
                {
                    for (int j = 0; j < vertexNumber; j++)
                    {
                        sw.Write(matrix[i, j].ToString() + " ");
                    }
                    sw.WriteLine();
                }
                sw.Flush();
                sw.Close();
                f.Close();
                MessageBox.Show("Đã lưu ma trận trọng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Không tồn tại đồ thị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //hàm để khi nhấp vào ô trong ma trận sẽ hiển thị đỉnh đầu, đỉnh cuối và trọng số
        private void showMatrix_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbHeadVertex.Text = (e.RowIndex + 1).ToString();
            cbTailVertex.Text = (e.ColumnIndex + 1).ToString();
            tbWeight.Text = (showMatrix[e.RowIndex, e.ColumnIndex].Value).ToString();
        }
    }
}
