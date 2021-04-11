using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EzTris
{
    public partial class locale : Form
    {
        public locale()
        {
            InitializeComponent();
        }
        Point lastpoint;
        String[,] matrice = new String[100, 100];
        String simb = "X", simbcpu = "O";
        String[] nomecpu = new string[22] { "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian",
            "Gisella", "Luca", "Giuseppe", "Pietro", "Anna", "Irene", "Giuseppa", "Rosanna", "Anselma", "Rebecca", "Rodolfo Stallone",
            "Germano Mosconi", };
        String avvers;
        Random rnd = new Random();
        int cnt, cnt2, ind, cont = 0, cont2 = 0, cnt3 = 6;
        Boolean utente = true, cpu = false, fir = false, comp = false, giocata1 = false, giocata2 = false, blck = false;
        int r = 0, c = 0, a = 0;
        private static readonly object syncLock = new object();
        int volte = 0;

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {


                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;


            }
        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            if (fir != true)
            {
                simb = "X";
                lbl_simb.Text = "Tu: X";
                simbcpu = "O";

            }
        }

        private void wt_Tick(object sender, EventArgs e)
        {
           
            volte++;
            int gioc = 0;
            Random rndm = new Random();
            if (volte == 1)
            {


                lock (syncLock)
                {
                    r = rndm.Next(0, 3);
                    c = rndm.Next(0, 3);
                }
                if (matrice[r, c] == null)
                    matrice[r, c] = simbcpu;
                else
                {

                    while (matrice[r, c] != null)
                    {
                        r = rndm.Next(0, 2);
                        c = rndm.Next(0, 2);
                       
                    }
                    if (matrice[r, c] != null)
                        matrice[r, c] = simbcpu;
                }
               
            }

            else
            {
                if (r == 1 && c == 1) //se la mossa prec della cpu e in mezzo
                {
                    if (giocata1 == false && giocata2 == false)
                    {
                        gioc = rndm.Next(1, 3);



                        if (gioc == 1 && matrice[r, c + 1] == null && matrice[r, c + 1] == null) //sx e dx
                        {

                            matrice[r, c + 1] = simbcpu;
                            giocata1 = true;
                            //c++;
                        }

                        else if (gioc == 2 && matrice[r + 1, c] == null && matrice[r - 1, c] == null) //sopra e sotto
                        {
                            matrice[r + 1, c] = simbcpu;
                            giocata2 = true;
                            // r++;

                        }

                        else
                        {

                            lock (syncLock)
                            {
                                r = rndm.Next(0, 3);
                                c = rndm.Next(0, 3);
                            }
                            if (matrice[r, c] == null)
                                matrice[r, c] = simbcpu;
                            else
                            {

                                while (matrice[r, c] != null)
                                {
                                    r = rndm.Next(0, 2);
                                    c = rndm.Next(0, 2);
                                   
                                }
                                if (matrice[r, c] != null)
                                    matrice[r, c] = simbcpu;
                            }
                        }

                    }

                    else if (giocata1 == true)
                    {
                        if (matrice[r, c - 1] == null)
                        {

                            matrice[r, c - 1] = simbcpu;
                            giocata1 = false;
                        }
                    }

                    else if (giocata2 == true)
                    {

                        if (matrice[r, c - 1] == null)
                        {

                            matrice[r, c - 1] = simbcpu;
                            giocata2 = false;
                        }
                    }

                    else {

                        lock (syncLock)
                        {
                            r = rndm.Next(0, 3);
                            c = rndm.Next(0, 3);
                        }
                        if (matrice[r, c] == null)
                            matrice[r, c] = simbcpu;
                        else
                        {

                            while (matrice[r, c] != null)
                            {
                                r = rndm.Next(0, 2);
                                c = rndm.Next(0, 2);
                               
                            }
                            if (matrice[r, c] != null)
                                matrice[r, c] = simbcpu;
                        }
                    }




                }

                else
                {
                    if (r != 2 && r != 0)
                    {
                        if (matrice[r + 1, c] == null && matrice[r - 1, c] == null)
                        {  //sx e dx                                         
                            matrice[r + 1, c] = simbcpu;
                            r++;

                        }
                        else if (matrice[r + 1, c] == null && matrice[r - 1, c] != null && c != 0)
                        {
                            matrice[r, c - 1] = simbcpu;
                            c--;
                        }
                        else if (matrice[r + 1, c] != null && matrice[r - 1, c] == null && c != 0)
                        {
                            matrice[r, c + 1] = simbcpu;
                            c++;
                        }

                        else
                        {
                            while (matrice[r, c] != null)
                            {
                                r = rndm.Next(0, 2);
                                c = rndm.Next(0, 2);
                                
                            }
                            if (matrice[r, c] == null)
                                matrice[r, c] = simbcpu;

                        }
                    }



                    else if (c != 2 && c != 0)
                    {
                        if (matrice[r, c + 1] == null && matrice[r, c - 1] == null)
                        {  //sopra e sotto                  
                            matrice[r, c + 1] = simbcpu;
                            c++;

                        }
                        else if (matrice[r, c + 1] == null && matrice[r, c - 1] != null)
                        {
                            matrice[r, c + 1] = simbcpu;
                            c++;

                        }
                        else if (matrice[r, c + 1] != null && matrice[r, c - 1] == null)
                        {
                            matrice[r, c - 1] = simbcpu;

                            c--;
                        }

                        else
                        {
                            while (matrice[r, c] != null)
                            {
                                r = rndm.Next(0, 2);
                                c = rndm.Next(0, 2);
                                
                            }
                            if (matrice[r, c] == null)
                                matrice[r, c] = simbcpu;

                        }
                    }

                    else 
                    {
                        lock (syncLock)
                        {
                            r = rndm.Next(0, 3);
                            c = rndm.Next(0, 3);
                        }
                        if (matrice[r, c] == null)
                            matrice[r, c] = simbcpu;
                        else
                        {

                            while (matrice[r, c] != null)
                            {
                                r = rndm.Next(0, 2);
                                c = rndm.Next(0, 2);
                                
                            }
                            if (matrice[r, c] != null)
                                matrice[r, c] = simbcpu;
                        }
                    }


                }


                 //chiamo metodo aggiornamento valori datagrid
                         //la cpu fa la sua mossa
               
               
            }
            wt.Stop();
            lbl_trn.Text = "Turno di " + "utente";
            blck = false;
            inser();
            comp = false;
        }

        private void lbl_o_Click(object sender, EventArgs e)
        {
            if (fir != true)
            {
                simb = " O";
                lbl_simb.Text = "Tu: O";
                simbcpu = "X";

            }

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void locale_Load(object sender, EventArgs e)
        {
            a = rnd.Next(0, 3);

            if (a == 1)
            {
                lbl_trn.Text = "Turno di " + avvers;
                wt.Start();

            }

            else
                lbl_trn.Text = "Turno di " + "utente";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer("sound/soundwrite.wav");
            player.Play();
            tmp.Interval = 4000;
            tmp.Start();
            tim.Interval = 200;
            tim.Start();
            int n = rnd.Next(0, 22);
            avvers = nomecpu[n];
            cnt2 = avvers.Length;
            wt.Interval = 2000;

            this.tab_tris.DefaultCellStyle.Font = new Font("Tahoma", 15);
            
            int cnt = 3;
            tab_tris.RowCount = cnt;
            tab_tris.ColumnCount = cnt;
            for (int a = 0; a < cnt; a++)
            {

                for (int h = 0; h < cnt; h++)
                {

                    tab_tris.Rows[a].Height = 94;
                    tab_tris.Columns[a].Width = 94;

                
                }

            }


        }

        private void tim_Tick(object sender, EventArgs e)
        {
            String ut = "utente";
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

        private void tab_tris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tab_tris.Rows[tab_tris.CurrentCell.RowIndex].Cells[tab_tris.CurrentCell.ColumnIndex].Value != "X"
              && tab_tris.Rows[tab_tris.CurrentCell.RowIndex].Cells[tab_tris.CurrentCell.ColumnIndex].Value != "O" && blck == false)
            {
                fir = true;
                this.tab_tris.ClearSelection();
                int column = tab_tris.CurrentCell.ColumnIndex; //colonna
                int row = tab_tris.CurrentCell.RowIndex;  //riga

                matrice[row, column] = simb;
                wt.Start();
                lbl_trn.Text = "Turno di " + avvers;
                inser();
                blck = true;

            }
              
            
        }

        private void inser() {

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
           

        }
        

        private void tab_tris_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

       
    }
}
