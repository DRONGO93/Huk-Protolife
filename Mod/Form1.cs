using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Mod
{
    public partial class Form1 : Form
    {
        //-----------------------------------------------------------------------
        #region Создание нажатие клавиш в приложении. В активном.
        [DllImport("user32.dll")]
        static extern void keybd_event(Keys keys, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        #endregion
        //-----------------------------------------------------------------------

        /// <summary>
        /// Глобальные переменные для формы.
        /// </summary>
        uint TypeTower = 1;
        uint LevelTower = 1;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            /// <summary>
            /// Обработка трея.
            /// </summary>
            #region Трей.
            /// <summary>
            /// Делаем невидимой нашу иконку в трее.
            /// </summary>
            notifyIcon1.Visible = false;
            /// <summary>
            /// добавляем Эвент или событие по 2му клику мышки,
            /// вызывая функцию  notifyIcon1_MouseDoubleClick
            /// </summary>
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
            /// <summary>
            /// Добавляем событие на изменение окна.
            /// </summary>
            this.Resize += new System.EventHandler(this.HideForm1);
            #endregion
            /// <summary>
            /// Подписка на событие нажатия клавиш.
            /// </summary>
            KBDHook.OnHookKeyPressEventHandler += new KBDHook.HookKeyPress(KBDHook_OnHookKeyPressEventHandler);
        }
       
        public void Form1_Load(object sender, EventArgs e)
        {
            /// <summary>
            /// Исходный интерфейс.
            /// </summary>
            label1.Text = Convert.ToString(TypeTower);
            label2.Text = Convert.ToString(LevelTower);
            pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\1-1.jpg");
            /// <summary>
            /// Кидаем хук на клавиатуру.
            /// </summary>
            KBDHook.InstallHook();
        }

        void KBDHook_OnHookKeyPressEventHandler(LLKHEventArgs e)
        {//Внимание здесь баг! Кнопки жмуться с залипанием постоянно.
            if (e.IsPressed == true && e.Keys == Keys.D1)
            {
                #region 1
                if (TypeTower == 1 && LevelTower == 1)
                {Bild111();}
                if (TypeTower == 1 && LevelTower == 2)
                {Bild121();}
                if (TypeTower == 1 && LevelTower == 3)
                {Bild131();}
                #endregion
                #region 2
                if (TypeTower == 2 && LevelTower == 1)
                {Bild211();}
                if (TypeTower == 2 && LevelTower == 2)
                { Bild221(); }
                if (TypeTower == 2 && LevelTower == 3)
                { Bild231(); }
                #endregion
                #region 3
                if (TypeTower == 3 && LevelTower == 1)
                { Bild311(); }
                #endregion
                #region 4
                //4-1 Нет.
                if (TypeTower == 4 && LevelTower == 2)
                { Bild412(); }
                #endregion
                #region 5
                if (TypeTower == 5 && LevelTower == 1)
                { Bild511(); }
                if (TypeTower == 5 && LevelTower == 2)
                { Bild521(); }
                if (TypeTower == 5 && LevelTower == 3)
                { Bild531(); }
                #endregion
                #region 6 //Гдето тут ошибка.
                if (TypeTower == 6 && LevelTower == 1)
                { Bild611(); }
                if (TypeTower == 6 && LevelTower == 2)
                { Bild612(); }
                if (TypeTower == 6 && LevelTower == 3)
                { Bild613(); }
                #endregion
                #region 7
                //7-1 Нет.
                if (TypeTower == 7 && LevelTower == 2)
                { Bild721(); }
                #endregion
            }
            if (e.IsPressed == true && e.Keys == Keys.D2)
            {
                #region 1
                if (TypeTower == 1 && LevelTower == 1)
                {Bild112();}
                if (TypeTower == 1 && LevelTower == 2)
                {Bild122();}
                if (TypeTower == 1 && LevelTower == 3)
                {Bild132();}
                #endregion
                #region 2
                if (TypeTower == 2 && LevelTower == 1)
                {Bild212();}
                if (TypeTower == 2 && LevelTower == 2)
                { Bild222(); }
                if (TypeTower == 2 && LevelTower == 3)
                { Bild232(); }
                #endregion
                #region 3
                if (TypeTower == 3 && LevelTower == 1)
                { Bild311(); }
                if (TypeTower == 3 && LevelTower == 2)
                { Bild322(); }
                #endregion
                #region 4
                if (TypeTower == 4 && LevelTower == 1)
                { Bild411(); }
                if (TypeTower == 4 && LevelTower == 2)
                { Bild412(); }
                #endregion
                #region 5
                if (TypeTower == 5 && LevelTower == 1)
                { Bild511(); }
                if (TypeTower == 5 && LevelTower == 2)
                { Bild521(); }
                if (TypeTower == 5 && LevelTower == 3)
                { Bild531(); }
                #endregion
                #region 6 //Гдето тут ошибка.
                if (TypeTower == 6 && LevelTower == 1)
                { Bild611(); }
                if (TypeTower == 6 && LevelTower == 2)
                { Bild622(); }
                if (TypeTower == 6 && LevelTower == 3)
                { Bild623(); }
                #endregion
                #region 7
                if (TypeTower == 7 && LevelTower == 1)
                { Bild712(); }
                if (TypeTower == 7 && LevelTower == 2)
                { Bild721(); }
                #endregion
            }
            if (e.IsPressed == true && e.Keys == Keys.D3)
            {
                #region 1
                if (TypeTower == 1 && LevelTower == 1)
                {Bild113();}
                if (TypeTower == 1 && LevelTower == 2)
                {Bild123();}
                if (TypeTower == 1 && LevelTower == 3)
                {Bild133();}
                #endregion
                #region 2
                if (TypeTower == 2 && LevelTower == 1)
                { Bild213(); }
                if (TypeTower == 2 && LevelTower == 2)
                { Bild223(); }
                if (TypeTower == 2 && LevelTower == 3)
                { Bild233(); }
                #endregion
                #region 3
                if (TypeTower == 3 && LevelTower == 1)
                { Bild311(); }
                #endregion
                #region 4
                //4-1 Нет.
                if (TypeTower == 4 && LevelTower == 2)
                { Bild412(); }
                if (TypeTower == 4 && LevelTower == 3)
                { Bild431(); }
                #endregion
                #region 5
                if (TypeTower == 5 && LevelTower == 1)
                { Bild511(); }
                if (TypeTower == 5 && LevelTower == 2)
                { Bild521(); }
                if (TypeTower == 5 && LevelTower == 3)
                { Bild531(); }
                #endregion
                #region 6 //Гдето тут ошибка.
                if (TypeTower == 6 && LevelTower == 1)
                { Bild611(); }
                if (TypeTower == 6 && LevelTower == 2)
                { Bild622(); }
                if (TypeTower == 6 && LevelTower == 3)
                { Bild623(); }
                #endregion
                #region 7
                //7-1 Нет.
                if (TypeTower == 7 && LevelTower == 2)
                { Bild721(); }
                #endregion
            }
            if (e.IsPressed == true && e.Keys == Keys.D4)
            {
                #region 1
                if (TypeTower == 1 && LevelTower == 1)
                { Bild114(); }
                if (TypeTower == 1 && LevelTower == 2)
                { Bild124(); }
                if (TypeTower == 1 && LevelTower == 3)
                { Bild134(); }
                #endregion
                #region 2
                if (TypeTower == 2 && LevelTower == 1)
                { Bild214(); }
                if (TypeTower == 2 && LevelTower == 2)
                { Bild224(); }
                if (TypeTower == 2 && LevelTower == 3)
                { Bild234(); }
                #endregion
                #region 3
                if (TypeTower == 3 && LevelTower == 1)
                { Bild311(); }
                if (TypeTower == 3 && LevelTower == 2)
                { Bild324(); }
                #endregion
                #region 4
                if (TypeTower == 4 && LevelTower == 1)
                { Bild411(); }
                if (TypeTower == 4 && LevelTower == 2)
                { Bild412(); }
                if (TypeTower == 4 && LevelTower == 3)
                { Bild431(); }
                #endregion
                #region 5
                if (TypeTower == 5 && LevelTower == 1)
                { Bild511(); }
                if (TypeTower == 5 && LevelTower == 2)
                { Bild521(); }
                if (TypeTower == 5 && LevelTower == 3)
                { Bild531(); }
                #endregion
                #region 6 //Гдето тут ошибка.
                if (TypeTower == 6 && LevelTower == 1)
                { Bild611(); }
                if (TypeTower == 6 && LevelTower == 2)
                { Bild622(); }
                if (TypeTower == 6 && LevelTower == 3)
                { Bild623(); }
                #endregion
                #region 7
                if (TypeTower == 7 && LevelTower == 1)
                { Bild711(); }
                if (TypeTower == 7 && LevelTower == 2)
                { Bild721(); }
                #endregion
            }
            if (e.IsPressed == true && e.Keys == Keys.D6)
            {
                #region 1
                if (TypeTower == 1 && LevelTower == 1)
                {Bild116();}
                if (TypeTower == 1 && LevelTower == 2)
                { Bild126();}
                if (TypeTower == 1 && LevelTower == 3)
                {Bild133();}
                #endregion
                #region 2
                if (TypeTower == 2 && LevelTower == 1)
                { Bild216(); }
                if (TypeTower == 2 && LevelTower == 2)
                { Bild226(); }
                if (TypeTower == 2 && LevelTower == 3)
                { Bild236(); }
                #endregion
                #region 3
                if (TypeTower == 3 && LevelTower == 1)
                { Bild311(); }
                if (TypeTower == 3 && LevelTower == 2)
                { Bild326(); }
                #endregion
                #region 4
                if (TypeTower == 4 && LevelTower == 1)
                { Bild411(); }
                if (TypeTower == 4 && LevelTower == 2)
                { Bild412(); }
                if (TypeTower == 4 && LevelTower == 3)
                { Bild431(); }
                #endregion
                #region 5
                if (TypeTower == 5 && LevelTower == 1)
                { Bild511(); }
                if (TypeTower == 5 && LevelTower == 2)
                { Bild521(); }
                if (TypeTower == 5 && LevelTower == 3)
                { Bild531(); }
                #endregion
                #region 6 //Гдето тут ошибка.
                if (TypeTower == 6 && LevelTower == 1)
                { Bild611(); }
                if (TypeTower == 6 && LevelTower == 2)
                { Bild622(); }
                if (TypeTower == 6 && LevelTower == 3)
                { Bild623(); }
                #endregion
                #region 7
                if (TypeTower == 7 && LevelTower == 1)
                { Bild711(); }
                if (TypeTower == 7 && LevelTower == 2)
                { Bild721(); }
                #endregion

            }
            if (e.IsPressed == true && e.Keys == Keys.D7)
            {
                #region 1
                if (TypeTower == 1 && LevelTower == 1)
                {Bild117();}
                if (TypeTower == 1 && LevelTower == 2)
                {Bild127();}
                if (TypeTower == 1 && LevelTower == 3)
                {Bild137();}
                #endregion
                #region 2
                if (TypeTower == 2 && LevelTower == 1)
                { Bild217(); }
                if (TypeTower == 2 && LevelTower == 2)
                { Bild227(); }
                if (TypeTower == 2 && LevelTower == 3)
                { Bild237(); }
                #endregion
                #region 3
                if (TypeTower == 3 && LevelTower == 1)
                { Bild311(); }
                #endregion
                #region 4
                //4-1 Нет.
                if (TypeTower == 4 && LevelTower == 2)
                { Bild412(); }
                if (TypeTower == 4 && LevelTower == 3)
                { Bild431(); }
                #endregion
                #region 5
                if (TypeTower == 5 && LevelTower == 1)
                { Bild511(); }
                if (TypeTower == 5 && LevelTower == 2)
                { Bild521(); }
                if (TypeTower == 5 && LevelTower == 3)
                { Bild531(); }
                #endregion
                #region 6 //Гдето тут ошибка.
                if (TypeTower == 6 && LevelTower == 1)
                { Bild611(); }
                if (TypeTower == 6 && LevelTower == 2)
                { Bild622(); }
                if (TypeTower == 6 && LevelTower == 3)
                { Bild623(); }
                #endregion
                #region 7
                //7-1 Нет.
                if (TypeTower == 7 && LevelTower == 2)
                { Bild721(); }
                #endregion
            }
            if (e.IsPressed == true && e.Keys == Keys.D8)
            {
                #region 1
                if (TypeTower == 1 && LevelTower == 1)
                {Bild118();}
                if (TypeTower == 1 && LevelTower == 2)
                {Bild128();}
                if (TypeTower == 1 && LevelTower == 3)
                {Bild138();}
                #endregion
                #region 2
                if (TypeTower == 2 && LevelTower == 1)
                { Bild218(); }
                if (TypeTower == 2 && LevelTower == 2)
                { Bild228(); }
                if (TypeTower == 2 && LevelTower == 3)
                { Bild238(); }
                #endregion
                #region 3
                if (TypeTower == 3 && LevelTower == 1)
                { Bild311(); }
                if (TypeTower == 3 && LevelTower == 2)
                { Bild328(); }
                #endregion
                #region 4 //Проверить, глаз замылился.
                if (TypeTower == 4 && LevelTower == 1)
                { Bild411(); }
                if (TypeTower == 4 && LevelTower == 2)
                { Bild412(); }
                if (TypeTower == 4 && LevelTower == 3)
                { Bild431(); }
                #endregion
                #region 5
                if (TypeTower == 5 && LevelTower == 1)
                { Bild511(); }
                if (TypeTower == 5 && LevelTower == 2)
                { Bild521(); }
                if (TypeTower == 5 && LevelTower == 3)
                { Bild531(); }
                #endregion
                #region 6 //Гдето тут ошибка.
                if (TypeTower == 6 && LevelTower == 1)
                { Bild611(); }
                if (TypeTower == 6 && LevelTower == 2)
                { Bild622(); }
                if (TypeTower == 6 && LevelTower == 3)
                { Bild623(); }
                #endregion
                #region 7
                if (TypeTower == 7 && LevelTower == 1)
                { Bild712(); }
                if (TypeTower == 7 && LevelTower == 2)
                { Bild721(); }
                #endregion
            }
            if (e.IsPressed == true && e.Keys == Keys.D9)
            {
                #region 1
                if (TypeTower == 1 && LevelTower == 1)
                {Bild119();}
                if (TypeTower == 1 && LevelTower == 2)
                {Bild129();}
                if (TypeTower == 1 && LevelTower == 3)
                {Bild139();}
                #endregion
                #region 2
                if (TypeTower == 2 && LevelTower == 1)
                { Bild219(); }
                if (TypeTower == 2 && LevelTower == 2)
                { Bild229(); }
                if (TypeTower == 2 && LevelTower == 3)
                { Bild239(); }
                #endregion
                #region 3
                if (TypeTower == 3 && LevelTower == 1)
                { Bild311(); }
                #endregion
                #region 4
                //4-1 Нет.
                if (TypeTower == 4 && LevelTower == 2)
                { Bild412(); }
                if (TypeTower == 4 && LevelTower == 3)
                { Bild431(); }
                #endregion
                #region 5
                if (TypeTower == 5 && LevelTower == 1)
                { Bild511(); }
                if (TypeTower == 5 && LevelTower == 2)
                { Bild521(); }
                if (TypeTower == 5 && LevelTower == 3)
                { Bild531(); }
                #endregion
                #region 6 //Гдето тут ошибка.
                if (TypeTower == 6 && LevelTower == 1)
                { Bild611(); }
                if (TypeTower == 6 && LevelTower == 2)
                { Bild622(); }
                if (TypeTower == 6 && LevelTower == 3)
                { Bild623(); }
                #endregion
                #region 7
                //7-1 Нет.
                if (TypeTower == 7 && LevelTower == 2)
                { Bild721(); }
                #endregion
            }
        }

        /// <summary>
        /// Основные конструкции отправки сообщений в приложение "Покнопочно".
        /// </summary>
        #region Кнопки движения, отправляем сообщение в стороннее приложение.
        public static void BildBlok()
        {keybd_event(Keys.Space , 0, 0, UIntPtr.Zero);}
        
        public void MoveLeft()
        {keybd_event(Keys.A, 0, 0, UIntPtr.Zero);}
        
        public void MoveRight()
        {keybd_event(Keys.D, 0, 0, UIntPtr.Zero);}
        
        public void MoveDown()
        {keybd_event(Keys.S, 0, 0, UIntPtr.Zero); }
           
        public void MoveUp()
        {keybd_event(Keys.W, 0, 0, UIntPtr.Zero);}
        
        #endregion

        /// <summary>
        /// Управление с формы.
        /// </summary>
        #region Кнопки на форме.
        private void button1_Click(object sender, EventArgs e)
        {BildBlok();}

        private void button2_Click(object sender, EventArgs e)
        {
            TypeTower = TypeTower - 1;
            if (TypeTower == 0)
            {
                TypeTower = 7;
            }
            label1.Text = Convert.ToString(TypeTower);
            ImSel(TypeTower, LevelTower);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TypeTower = TypeTower + 1;
            if (TypeTower > 7)
            {
                TypeTower = 1;
            }
            label1.Text = Convert.ToString(TypeTower);
            ImSel(TypeTower, LevelTower);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TypeTower == 1)
            {
                LevelTower = LevelTower + 1;
                if (LevelTower > 3)
                {
                    LevelTower = 1;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 2)
            {
                LevelTower = LevelTower + 1;
                if (LevelTower > 3)
                {
                    LevelTower = 1;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 3)
            {
                LevelTower = LevelTower + 1;
                if (LevelTower > 2)
                {
                    LevelTower = 1;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 4)
            {
                LevelTower = LevelTower + 1;
                if (LevelTower > 3)
                {
                    LevelTower = 1;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 5)
            {
                LevelTower = LevelTower + 1;
                if (LevelTower > 3)
                {
                    LevelTower = 1;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 6)
            {
                LevelTower = LevelTower + 1;
                if (LevelTower > 2)
                {
                    LevelTower = 1;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 7)
            {
                LevelTower = LevelTower + 1;
                if (LevelTower > 2)
                {
                    LevelTower = 1;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            ImSel(TypeTower, LevelTower);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TypeTower == 1)
            {
                LevelTower = LevelTower - 1;
                if (LevelTower == 0)
                {
                    LevelTower = 3;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 2)
            {
                LevelTower = LevelTower - 1;
                if (LevelTower == 0)
                {
                    LevelTower = 3;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 3)
            {
                LevelTower = LevelTower - 1;
                if (LevelTower == 0)
                {
                    LevelTower = 2;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 4)
            {
                LevelTower = LevelTower - 1;
                if (LevelTower == 0)
                {
                    LevelTower = 3;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 5)
            {
                LevelTower = LevelTower - 1;
                if (LevelTower == 0)
                {
                    LevelTower = 3;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 6)
            {
                LevelTower = LevelTower - 1;
                if (LevelTower == 0)
                {
                    LevelTower = 2;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            if (TypeTower == 7)
            {
                LevelTower = LevelTower - 1;
                if (LevelTower == 0)
                {
                    LevelTower = 2;
                }
                label2.Text = Convert.ToString(LevelTower);
            }
            ImSel(TypeTower, LevelTower);
        }
        #endregion

        /// <summary>
        /// Модуль отображения картинок башен.
        /// </summary>
        public void ImSel(uint TypeTower, uint LevelTower)
        {
            if (TypeTower == 1 && LevelTower == 1)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\1-1.jpg"); }
            if (TypeTower == 1 && LevelTower == 2)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\1-2.jpg"); }
            if (TypeTower == 1 && LevelTower == 3)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\1-3.jpg"); }
            if (TypeTower == 2 && LevelTower == 1)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\2-1.jpg"); }
            if (TypeTower == 2 && LevelTower == 2)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\2-2.jpg"); }
            if (TypeTower == 2 && LevelTower == 3)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\2-3.jpg"); }
            if (TypeTower == 3 && LevelTower == 1)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\3-1.jpg"); }
            if (TypeTower == 3 && LevelTower == 2)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\3-2.jpg"); }
            if (TypeTower == 4 && LevelTower == 1)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\4-1.jpg"); }
            if (TypeTower == 4 && LevelTower == 2)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\4-2.jpg"); }
            if (TypeTower == 4 && LevelTower == 3)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\4-3.jpg"); }
            if (TypeTower == 5 && LevelTower == 1)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\5-1.jpg"); }
            if (TypeTower == 5 && LevelTower == 2)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\5-2.jpg"); }
            if (TypeTower == 5 && LevelTower == 3)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\5-3.jpg"); }
            if (TypeTower == 6 && LevelTower == 1)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\6-1.jpg"); }
            if (TypeTower == 6 && LevelTower == 2)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\6-2.jpg"); }
            if (TypeTower == 7 && LevelTower == 1)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\7-1.jpg"); }
            if (TypeTower == 7 && LevelTower == 2)
            { pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Picture\7-2.jpg"); }
        }

        /// <summary>
        /// Модуль отображения иконки в трее.
        /// </summary>
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // делаем нашу иконку скрытой
            notifyIcon1.Visible = false;
            // возвращаем отображение окна в панели
            this.ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Механизм работы с иконкой в трее.
        /// </summary>
        public void HideForm1(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие        
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                this.ShowInTaskbar = false;
                // делаем нашу иконку в трее активной
                notifyIcon1.Visible = true;
            }
        }

        /// <summary>
        /// Проверка на наличие запущеной игры "Protolife" в системе Windows.
        /// </summary>
        #region Подключение к игре.
        /// <summary>
        /// Подключаем окно, и клавиатуру.
        /// </summary>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        #endregion
        public void ProvRunProtolife()
        {
            IntPtr Protolife = FindWindow("Chrome_WidgetWin_1", "Protolife");
            if (Protolife == IntPtr.Zero)
            {
                MessageBox.Show("Приложение не запущено.");
                return;
            }
        }

        /// <summary>
        /// Снять хук по закрытию окна.
        /// </summary>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {   
            KBDHook.UnInstallHook();
        }

        /// <summary>
        /// Заготовки комбинаций нажатия клавиш для постройки строений.
        /// </summary>
        #region Конструкции строений
        #region Конструкции 1-1
        public void Bild111()
        { BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild112()
        { BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); }
        public void Bild113()
        { BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild114()
        { BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); }
        public void Bild116()
        { BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); }
        public void Bild117()
        { BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); }
        public void Bild118()
        { BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); }
        public void Bild119()
        { BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); }
        #endregion
        #region Конструкции 1-2
        public void Bild121()
        { BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild122()
        { BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); }
        public void Bild123()
        { BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild124()
        { BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); }
        public void Bild126()
        { BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); }
        public void Bild127()
        { BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); }
        public void Bild128()
        { BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); }
        public void Bild129()
        { BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); }
        #endregion
        #region Конструкции 1-3
        public void Bild131()
        { BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild132()
        { BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); }
        public void Bild133()
        { BildBlok(); MoveDown(); BildBlok(); MoveDown(); BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); }
        public void Bild134()
        { BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); }
        public void Bild136()
        { BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); }
        public void Bild137()
        { BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); MoveRight(); BildBlok(); }
        public void Bild138()
        { BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); }
        public void Bild139()
        { BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); }
        #endregion
        #region Конструкции 1-4
        public void Bild141()
        { BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); }
        public void Bild142()
        { BildBlok(); MoveDown(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild143()
        { BildBlok(); MoveRight(); MoveDown(); BildBlok(); MoveRight(); BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); }
        public void Bild144()
        { BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); }
        public void Bild146()
        { BildBlok(); MoveRight(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); }
        public void Bild147()
        { BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); MoveRight(); BildBlok(); MoveDown(); MoveRight(); BildBlok(); }
        public void Bild148()
        { BildBlok(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveDown(); MoveRight(); BildBlok(); MoveDown(); MoveRight(); BildBlok(); MoveDown(); BildBlok(); }
        public void Bild149()
        { BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); }

        #endregion
        #region Конструкции 2-1
        public void Bild211()
        { BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild212()
        { BildBlok(); MoveRight(); MoveDown(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveRight(); MoveDown(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); }
        public void Bild213()
        { BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild214()
        { BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); }
        public void Bild216()
        { BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); }
        public void Bild217()
        { BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); }
        public void Bild218()
        { BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveRight(); MoveDown(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveDown(); MoveRight(); BildBlok(); }
        public void Bild219()
        { BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); }
        #endregion
        #region Конструкции 2-2
        public void Bild221()
        { BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild222()
        { BildBlok(); MoveRight(); MoveDown(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveRight(); MoveDown(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); }
        public void Bild223()
        { BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild224()
        { BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); }
        public void Bild226()
        { BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); }
        public void Bild227()
        { BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); }
        public void Bild228()
        { BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveRight(); MoveDown(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveDown(); MoveRight(); BildBlok(); }
        public void Bild229()
        { BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); }
        #endregion
        #region Конструкции 2-3
        public void Bild231()
        { BildBlok(); MoveLeft(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); MoveDown(); BildBlok(); }
        public void Bild232()
        { BildBlok(); MoveRight(); MoveDown(); BildBlok(); MoveDown(); BildBlok(); MoveDown(); BildBlok(); MoveRight(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveLeft(); MoveLeft(); BildBlok(); }
        public void Bild233()
        { BildBlok(); MoveRight(); BildBlok(); MoveDown(); MoveRight(); BildBlok(); MoveDown(); MoveRight(); BildBlok(); MoveUp(); MoveRight(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); MoveDown(); BildBlok(); }
        public void Bild234()
        { BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); MoveRight(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveDown(); MoveDown(); BildBlok(); }
        public void Bild236()
        { BildBlok(); MoveUp(); MoveRight(); BildBlok(); MoveRight(); BildBlok(); MoveRight(); BildBlok(); MoveUp(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveDown(); MoveDown(); BildBlok(); }
        public void Bild237()
        { BildBlok(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveDown(); MoveRight(); BildBlok(); MoveDown(); MoveRight(); BildBlok(); MoveRight(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); }
        public void Bild238()
        { BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); MoveRight(); BildBlok(); MoveDown(); BildBlok(); MoveDown(); BildBlok(); MoveDown(); MoveRight(); BildBlok(); MoveLeft(); MoveLeft(); BildBlok(); }
        public void Bild239()
        { BildBlok(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveDown(); MoveRight(); BildBlok(); }
        #endregion
        #region Конструкции 3-1
        public void Bild311()
        { BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); }
        #endregion
        #region Конструкции 3-2
        public void Bild322()
        { Bild328(); }
        public void Bild324()
        { BildBlok(); MoveRight(); BildBlok(); MoveUp(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); }
        public void Bild326()
        { Bild324(); }
        public void Bild328()
        { BildBlok(); MoveUp(); BildBlok(); MoveRight(); MoveRight(); BildBlok(); MoveDown(); BildBlok(); }
        #endregion
        #region Конструкции 4-1
        public void Bild411()
        { BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveDown(); BildBlok(); MoveDown(); BildBlok(); MoveRight(); BildBlok(); }
        public void Bild412()
        { BildBlok(); MoveDown(); BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); MoveRight(); BildBlok(); MoveDown(); BildBlok(); }
        #endregion
        #region Конструкции 4-2
        public void Bild421()
        { BildBlok(); MoveRight(); BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveDown(); BildBlok(); }
        #endregion
        #region Конструкции 4-3
        public void Bild431()
        { BildBlok(); MoveRight(); BildBlok(); MoveRight(); BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveLeft(); BildBlok(); MoveDown(); BildBlok(); MoveDown(); BildBlok(); }
        #endregion
        #region Конструкции 5-1
        public void Bild511()
        { BildBlok(); MoveRight(); MoveRight(); BildBlok(); MoveUp(); MoveUp(); BildBlok(); MoveLeft(); MoveLeft(); BildBlok(); }
        #endregion
        #region Конструкции 5-2
        public void Bild521()
        { BildBlok(); MoveDown(); MoveRight(); BildBlok(); MoveUp(); MoveUp(); MoveUp(); MoveUp(); BildBlok(); MoveDown(); MoveLeft(); BildBlok(); MoveLeft(); MoveLeft(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveDown(); MoveDown(); MoveDown(); MoveDown(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); }
        #endregion
        #region Конструкции 5-3
        public void Bild531()
        { BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); MoveUp(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); MoveLeft(); BildBlok(); MoveDown(); BildBlok(); MoveLeft(); BildBlok(); MoveDown(); MoveDown(); BildBlok(); MoveRight(); BildBlok(); MoveDown(); BildBlok(); }
        #endregion
        #region Конструкции 6-1
        public void Bild611()
        { BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild612()
        { BildBlok(); MoveLeft(); MoveDown(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveLeft(); MoveDown(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); }
        public void Bild613()
        { BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild614()
        { BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); }
        #endregion
        #region Конструкции 6-2
        public void Bild621()
        { BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); MoveLeft(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild622()
        { BildBlok(); MoveLeft(); MoveDown(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); MoveLeft(); MoveDown(); BildBlok(); MoveLeft(); MoveUp(); BildBlok(); }
        public void Bild623()
        { BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); }
        public void Bild624()
        { BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); MoveUp(); MoveLeft(); BildBlok(); MoveRight(); MoveUp(); BildBlok(); }
        #endregion
        #region Конструкции 7-1
        public void Bild711()
        { BildBlok(); MoveRight(); MoveRight(); BildBlok(); MoveUp(); BildBlok(); MoveDown(); MoveDown(); BildBlok(); MoveUp(); MoveRight(); MoveRight(); BildBlok(); }
        public void Bild712()
        { BildBlok(); MoveDown(); MoveDown(); BildBlok(); MoveLeft(); BildBlok(); MoveRight(); MoveRight(); BildBlok(); MoveLeft(); MoveDown(); MoveDown(); BildBlok(); }
        #endregion
        #region Конструкции 7-2
        public void Bild721()
        { BildBlok(); MoveUp(); MoveUp(); BildBlok(); MoveDown(); MoveDown(); MoveRight(); MoveRight(); BildBlok(); MoveLeft(); MoveLeft(); MoveLeft(); MoveLeft(); BildBlok(); MoveRight(); MoveRight(); MoveDown(); MoveDown(); BildBlok(); }
        #endregion
        #endregion

    }
}