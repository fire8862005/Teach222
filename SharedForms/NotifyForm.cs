using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SharedForms
{
    public partial class NotifyForm : Form
    {
        #region Win32API
        [DllImport("USER32.DLL")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, UInt32 bRevert);
        [DllImport("USER32.DLL")]
        private static extern UInt32 RemoveMenu(IntPtr hMenu, UInt32 nPosition, UInt32 wFlags);
        private const UInt32 SC_CLOSE = 0x0000F060;
        private const UInt32 MF_BYCOMMAND = 0x00000000;
        #endregion

        string _message;
        public NotifyForm() : this("")
        {
        }

        Timer closeTimer;
        DateTime timeStart = DateTime.MinValue;
        public int DueSecond { get; set; }
        public NotifyForm(string message, int duesecond = 0)
        {
            DueSecond = duesecond;
            _message = message;
            InitializeComponent();
            txtMessage.Text = _message;
            //   IntPtr hMenu = GetSystemMenu(this.Handle, 0);
            //   RemoveMenu(hMenu, SC_CLOSE, MF_BYCOMMAND);
            TopMost = true;
            ShowInTaskbar = false;
            picClose.MouseEnter += PicClose_MouseEnter;
            picClose.MouseLeave += PicClose_MouseLeave;
            MouseEnter += NotifyForm_MouseEnter;
            MouseLeave += NotifyForm_MouseLeave;

            closeTimer = new Timer();
            closeTimer.Interval = 1000;
            closeTimer.Tick += CloseTimer_Tick;
        }

        private void NotifyForm_MouseLeave(object sender, EventArgs e)
        {
            timeStart = DateTime.Now;
            closeTimer.Start();
        }

        private void NotifyForm_MouseEnter(object sender, EventArgs e)
        {
            closeTimer.Stop();
        }

        private void PicClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;

        }

        private void PicClose_MouseEnter(object sender, EventArgs e)
        {
            closeTimer.Stop();
            picClose.BackColor = Color.Blue;

        }

        public void SetMessage(string message, int dueSecond = 0)
        {
            txtMessage.Text = _message = message;
            if (dueSecond != 0)
            {
                DueSecond = dueSecond;
            }
         
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            if (DueSecond > 0 && timeStart != DateTime.MinValue)
            {
                if (DateTime.Now.Subtract(timeStart).TotalSeconds >= DueSecond)
                {
                    this.Close();
                }
            }
        }

        private int currentX;//������             
        private int currentY;//������         
        private int screenHeight;//��Ļ�߶�       
        private int screenWidth;//��Ļ���       
        int AW_ACTIVE = 0x20000; //����ڣ���ʹ����AW_HIDE��־��Ҫʹ�������־  
        int AW_HIDE = 0x10000;//���ش���       
        int AW_BLEND = 0x80000;// ʹ�õ��뵭��Ч��    
        int AW_SLIDE = 0x40000;//ʹ�û������Ͷ���Ч����Ĭ��Ϊ�����������ͣ���ʹ��AW_CENTER��־ʱ�������־�ͱ�����  
        int AW_CENTER = 0x0010;//��ʹ����AW_HIDE��־����ʹ���������ص�������������չ  
        int AW_HOR_POSITIVE = 0x0001;//����������ʾ���ڣ��ñ�־�����ڹ��������ͻ���������ʹ�á�ʹ��AW_CENTER��־ʱ���Ըñ�־   
        int AW_HOR_NEGATIVE = 0x0002;//����������ʾ���ڣ��ñ�־�����ڹ��������ͻ���������ʹ�á�ʹ��AW_CENTER��־ʱ���Ըñ�־    
        int AW_VER_POSITIVE = 0x0004;//�Զ�������ʾ���ڣ��ñ�־�����ڹ��������ͻ���������ʹ�á�ʹ��AW_CENTER��־ʱ���Ըñ�־   
        int AW_VER_NEGATIVE = 0x0008;//����������ʾ���ڣ��ñ�־�����ڹ��������ͻ���������ʹ�á�ʹ��AW_CENTER��־ʱ���Ըñ�־

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dateTime, int dwFlags);//hwnd���ھ��.dateTime:����ʱ��.dwFlags:�����������

        private void frm_ShowMessage_Load(object sender, EventArgs e)
        {
            if (DueSecond == 0)
            {
                DueSecond = 5;
            }
            FormCollection fc = Application.OpenForms;
            int height = 0;
            foreach (Form form in fc)
            {
                if (form.Name == "NotifyForm")
                {
                    height += Height + 10;
                }
            }
            // labMessage.Text = height.ToString();
            currentX = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            currentY = Screen.PrimaryScreen.WorkingArea.Height - height;
            this.Location = new Point(currentX, currentY);
            AnimateWindow(this.Handle, 300, AW_SLIDE | AW_VER_NEGATIVE);
            timeStart = DateTime.Now;
            closeTimer.Start();
            //  AnimateWindow(this.Handle, 300, AW_SLIDE | AW_VER_POSITIVE);


        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}