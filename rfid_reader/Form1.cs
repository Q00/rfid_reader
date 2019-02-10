using System;
using System.Windows.Forms;
using engine;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO.Ports;

namespace rfid_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1 = new SerialPort();
            serialPort1.PortName = "COM1"; //연결할 포트
            serialPort1.BaudRate = 9600; //보레이트 (통신속도)
            serialPort1.DataBits = 8; //데이터비트
            serialPort1.Parity = Parity.None; //패리티 (없음으로)
            serialPort1.StopBits = StopBits.One; //(정지비트는 1)

            serialPort1.Open(); //연결 포트 개방
            Console.WriteLine(222222222);
            textBox1.Text = serialPort1.ReceivedBytesThreshold.ToString();
            textBox2.Text = serialPort1.BytesToRead.ToString();
            Console.WriteLine(serialPort1.BytesToRead);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //이벤트발생
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs s)
        {
            Console.WriteLine("load");
            this.Invoke(new EventHandler(sportRCV));
        }

        private void sportRCV(object sender, EventArgs e)
        {
            Console.WriteLine(123123123123123);
            Console.WriteLine(serialPort1.BytesToRead);
            if (serialPort1.BytesToRead > 0) //데이터가 읽혀지면 출력
            {
                textBox2.Text = serialPort1.ReadExisting();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //이벤트발생
        }

        private async void run()
        {
            Start st = new Start();
            var task1 = Task<List<rfid_tag_struct>>.Run(() => st.start_loop());
            var rfid_list = await task1;

            foreach(rfid_tag_struct data in rfid_list)
            {
                dataGridView1.Rows.Add(data.Serial,data.Name, data.Price );
            }

            
        }
    }
}
