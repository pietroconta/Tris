using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace EzTris
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Point lastpoint;
        String[,] matrice = new String[100, 100];
        String simb = "X", simb2 = "O";
        String ut = "";

        String avvers;
        Random rnd = new Random();
        int cnt, cnt2, ind, cont = 0, cont2 = 0, cnt3 = 6;
        Boolean comp = false;
        int punt1, punt2 = 0;
        public static String nomevinc = "";
        Boolean block = false;

        private void tab_tris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if (tab_tris.Rows[tab_tris.CurrentCell.RowIndex].Cells[tab_tris.CurrentCell.ColumnIndex].Value != "X" 
                && tab_tris.Rows[tab_tris.CurrentCell.RowIndex].Cells[tab_tris.CurrentCell.ColumnIndex].Value != "O" && block == false)
            {

                if (comp == false)
                {
                    
                    lbl_trn.Text = "Turno di: " + avvers;
                    int column = tab_tris.CurrentCell.ColumnIndex; //colonna
                    int row = tab_tris.CurrentCell.RowIndex; //riga
                    tab_tris.CurrentCell.Selected = false;

                    matrice[row, column] = simb;

                    inser();
                    comp = true;

                    int pnt = 0;


                    for (int r = 0; r < 3; r++)  //dx sx
                    {
                        pnt = 0;

                        for (int c = 0; c < 3; c++)
                        {

                            if (matrice[r, c] == simb)
                            {

                                pnt++;

                                if (pnt == 3) //vince il gioc 1
                                {


                                    punt1++;
                                    lbl_x.Text = simb + ": " + punt1;
                                    tab_tris.Rows[r].Cells[c].Style.BackColor = Color.Gold;
                                    tab_tris.Rows[r].Cells[c - 1].Style.BackColor = Color.Gold;
                                    tab_tris.Rows[r].Cells[c - 2].Style.BackColor = Color.Gold;
                                    block = true;
                                    dlt.Start();                                 
                                    break;
                                }

                            }
                        }
                    }
                    int cd = 0;
                    pnt = 0;
                    for (int r = 0; r < 3; r++)  //diagonale da in alto a sx fino  a in basso a dx
                    {




                        if (matrice[r, cd] == simb)
                        {

                            pnt++;

                            if (pnt == 3) //vince il gioc 1
                            {


                                punt1++;
                                lbl_x.Text = simb + ": " + punt1;
                                tab_tris.Rows[r].Cells[cd].Style.BackColor = Color.Gold;
                                tab_tris.Rows[r - 1].Cells[cd - 1].Style.BackColor = Color.Gold;
                                tab_tris.Rows[r - 2].Cells[cd - 2].Style.BackColor = Color.Gold;
                                block = true;
                                dlt.Start();
                                break;
                            }


                        }
                        cd++;
                    }

                    cd = 0;
                    pnt = 0;
                    for (int r = 2; r != -1; r--)  //diagonale da in alto a sx fino  a in basso a dx
                    {




                        if (matrice[r, cd] == simb)
                        {

                            pnt++;

                            if (pnt == 3) //vince il gioc 1
                            {


                                punt1++;
                                lbl_x.Text = simb + ": " + punt1;
                                tab_tris.Rows[r].Cells[cd].Style.BackColor = Color.Gold;
                                tab_tris.Rows[r + 1].Cells[cd - 1].Style.BackColor = Color.Gold;
                                tab_tris.Rows[r + 2].Cells[cd - 2].Style.BackColor = Color.Gold;
                                block = true;
                                dlt.Start();
                                break;
                            }


                        }
                        cd++;
                    }

                   
                    pnt = 0;
                    r = 0;
                    for (cd = 0; cd <= 3; cd++)  //su e giú
                    {




                        if (matrice[r, cd] == simb && matrice[r + 1, cd] == simb && matrice[r + 2, cd] == simb)
                        {

                                 punt1++;
                                lbl_x.Text = simb + ": " + punt1;
                                tab_tris.Rows[r].Cells[cd].Style.BackColor = Color.Gold;
                                tab_tris.Rows[r + 1].Cells[cd].Style.BackColor = Color.Gold;
                                tab_tris.Rows[r + 2].Cells[cd].Style.BackColor = Color.Gold;
                                block = true;
                                dlt.Start();
                                break;
                            

                        }
                        
                    }

                    if (punt1 == 3)  //vince ut
                    {

                        nomevinc = ut;
                        win.Start();
                    }
                }



                else   //controlli vincita giocatore 2
                {

                    this.tab_tris.ClearSelection();
                    lbl_trn.Text = "Turno di: " + ut;
                    int column = tab_tris.CurrentCell.ColumnIndex; //colonna
                    int row = tab_tris.CurrentCell.RowIndex;  //riga

                    matrice[row, column] = simb2;
                    inser();
                    comp = false;


                    int pnt = 0;


                    //controlli vincita round
                    for (int r = 0; r < 3; r++)  //dx sx
                    {
                        pnt = 0;

                        for (int c = 0; c < 3; c++)
                        {

                            if (matrice[r, c] == simb2)
                            {

                                pnt++;

                                if (pnt == 3) //vince il gioc 2
                                {


                                    punt2++;
                                    lbl_o.Text = simb2 + ": " + punt2;
                                    tab_tris.Rows[r].Cells[c].Style.BackColor = Color.Gold;
                                    tab_tris.Rows[r].Cells[c - 1].Style.BackColor = Color.Gold;
                                    tab_tris.Rows[r].Cells[c - 2].Style.BackColor = Color.Gold;
                                    block = true;
                                    dlt.Start();
                                    break;
                                }

                            }
                        }
                    }
                    int cd = 0;
                    pnt = 0;
                    for (int r = 0; r < 3; r++)  //diagonale da in alto a sx fino  a in basso a dx
                    {




                        if (matrice[r, cd] == simb2)
                        {

                            pnt++;

                            if (pnt == 3) //vince il gioc 2
                            {


                                punt2++;
                                lbl_o.Text = simb2 + ": " + punt2;
                                tab_tris.Rows[r].Cells[cd].Style.BackColor = Color.Gold;
                                tab_tris.Rows[r - 1].Cells[cd - 1].Style.BackColor = Color.Gold;
                                tab_tris.Rows[r - 2].Cells[cd - 2].Style.BackColor = Color.Gold;
                                block = true;
                                dlt.Start();
                                break;
                            }


                        }
                        cd++;
                    }

                    cd = 0;
                    pnt = 0;
                    for (int r = 2; r != -1; r--)  //diagonale da in alto a sx fino  a in basso a dx
                    {




                        if (matrice[r, cd] == simb2)
                        {

                            pnt++;

                            if (pnt == 3) //vince il gioc 2
                            {


                                punt2++;
                                lbl_o.Text = simb2 + ": " + punt2;
                                tab_tris.Rows[r].Cells[cd].Style.BackColor = Color.Gold;
                                tab_tris.Rows[r + 1].Cells[cd - 1].Style.BackColor = Color.Gold;
                                tab_tris.Rows[r + 2].Cells[cd - 2].Style.BackColor = Color.Gold;
                                block = true;
                                dlt.Start();
                                break;
                            }


                        }
                        cd++;
                    }


                    pnt = 0;
                    r = 0;
                    for (cd = 0; cd <= 3; cd++)  //su e giú
                    {




                        if (matrice[r, cd] == simb2 && matrice[r + 1, cd] == simb2 && matrice[r + 2, cd] == simb2)
                        {

                            punt2++;
                            lbl_o.Text = simb2 + ": " + punt2;
                            tab_tris.Rows[r].Cells[cd].Style.BackColor = Color.Gold;
                            tab_tris.Rows[r + 1].Cells[cd].Style.BackColor = Color.Gold;
                            tab_tris.Rows[r + 2].Cells[cd].Style.BackColor = Color.Gold;
                            block = true;
                            dlt.Start();
                            break;


                        }

                    }

                    if (punt2 == 3)  //vince gioc 2
                    {
                        block = true;
                        nomevinc = avvers;
                        win.Start();
                        
                    }

                }

            }
        }


        private void clear(){

            for (int i = 0; i < 3; i++) {


                for (int u = 0; u < 3; u++) {

                    matrice[i, u] = null;
                
                
                }
            
            
            }

            inser();
        
        
        }

        private void dlt_Tick(object sender, EventArgs e)
        {
            dlt.Stop();
            block = false;
            clear();
        }

        private void inser()
        {

            for (int a = 0; a < 3; a++)
            {


                for (int j = 0; j < 3; j++)
                {

                    tab_tris.Rows[a].Cells[j].Style.BackColor = Color.White;
                    tab_tris.Rows[a].Cells[j].Value = matrice[a, j];
                    if (matrice[a, j] == "X")
                        tab_tris.Rows[a].Cells[j].Style.ForeColor = Color.Red;
                    else
                        tab_tris.Rows[a].Cells[j].Style.ForeColor = Color.Black;
                }

            }

            comp = true;
            int cas = 0;

            for (int r = 0; r < 3; r++)  //dx sx
            {           

                for (int c = 0; c < 3; c++)
                {
                    if (matrice[r, c] == "X" || matrice[r, c] == "O")
                        cas++;

                }
            }
            if (cas == 9)
            {
                dlt.Start();
                block = true;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {


                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;


            }
        }

        private void wt_Tick(object sender, EventArgs e)
        {

        }

        private void tim_Tick(object sender, EventArgs e)
        {
            
            if (cnt2 > 0)
            {
                lbl_cpu.Text += avvers[cont];
                cnt2--;
                cont++;
            }

            if (cnt3 > 0)
            {
                lbl_utente.Text += ut[cont2];
                cnt3--;
                cont2++;
            }
            else
                tim.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void win_Tick(object sender, EventArgs e)
        {
        
            block = false;
            vittoria frm = new vittoria();
            this.Hide();
            frm.Show();
            win.Stop();
        }

        private void tmp_Tick(object sender, EventArgs e)
        {
            lbl_utente.Visible = false;
            lbl_cpu.Visible = false;
            vs.Visible = false;
            tab_tris.Visible = true;
            lbl_o.Visible = true;
            lbl_x.Visible = true;
            tmp.Stop();
            lbl_simb.Visible = true;
            lbl_trn.Visible = true;
        }

        int r = 0, c = 0;
        private static readonly object syncLock = new object();
        int volte = 0;
        private void lbl_simb_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //  tab_tris.CurrentCell.Selected = false;
            
            dlt.Interval = 3000;
            Random rnd = new Random();
            int gn = 0;
            lock (syncLock)
            {
                gn = rnd.Next(1, 3);
            }
            bool err = false;
            ut = "";
            avvers = "";
            while (ut.Length < 6 && avvers.Length<6)
            {
                if (err == true)
                    MessageBox.Show("Hai inserito nomi troppo corti, inserisci nomi che siano piu' di 5 caratteri");
                ut = Interaction.InputBox("Inserisci il nome del giocatore 1", "");
                avvers = Interaction.InputBox("Inserisci il nome del giocatore 2", "");
                err = true;
            }
            if (gn == 1)
            {
                comp = false;
                lbl_trn.Text = "Turno di: " + ut;
            }
            else
            {
               
                comp = true;
                lbl_trn.Text = "Turno di: " + avvers;
            }

            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sound/soundwrite.wav");
            player.Play();
            tmp.Interval = 4000;
            tmp.Start();
            tim.Interval = 200;
            tim.Start();
            int n = rnd.Next(0, 22);
            
            cnt2 = avvers.Length;
            

            this.tab_tris.DefaultCellStyle.Font = new Font("Tahoma", 15);

            int cnt = 3;
            tab_tris.RowCount = cnt;
            tab_tris.ColumnCount = cnt;
            tab_tris.Rows[0].Cells[0].Selected = false;

            for (int a = 0; a < cnt; a++)
            {

                for (int h = 0; h < cnt; h++)
                {

                    tab_tris.Rows[a].Height = 94;
                    tab_tris.Columns[a].Width = 94;


                }

            }
           
        }

        private void tab_tris_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
