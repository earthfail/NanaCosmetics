using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class homeU : System.Web.UI.Page
{
    static int[,] board = new int[3, 3];
    //need to add stack for moves
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    protected void check_list(object sender, EventArgs e)
    {
        fill_letters(sender, e);
        init_board();
        if (whowon() != 10)
        {
            score.Visible = true;
            if (whowon() != 0)
                score.Text = board_value(whowon()) + " WON!";
            else
                score.Text = "TIED!";
            return;
        }
        else
        {
            bmove();
            print();
        }
        
    }
    protected void fill_letters(object sender,EventArgs e)
    {
        ((Button)sender).Text = player.Text;
    }
    private void init_board()
    {

        board[0, 0] = lab_value(l00);//i can now do it with for but don't want to change it
        board[0, 1] = lab_value(l01);
        board[0, 2] = lab_value(l02);
        board[1, 0] = lab_value(l10);
        board[1, 1] = lab_value(l11);
        board[1, 2] = lab_value(l12);
        board[2, 0] = lab_value(l20);
        board[2, 1] = lab_value(l21);
        board[2, 2] = lab_value(l22);
    }
    private int lab_value(Button lb)
    {
        if (lb.Text.CompareTo("X") == 0)
            return 1;
        if (lb.Text.CompareTo("O") == 0)
            return -1;
        return 0;
    }
    private string board_value(int a)
    {
        if (a == 1)
            return "X";
        if (a == -1)
            return "O";
        return " ";
    }
    private int whowon()// 0 they tied,1 X won,-1 O won , 10 it did not end
    {
        int square, i = -1, j = -1;
        for (i = 0; i < 3; i++)
        {
            square = board[i, 0];
            if (square != 0)
            {
                for (j = 0; j < 3; j++)
                    if (board[i, j] != square) break;
                if (j == 3) return square;
            }
        }
        for (i = 0; i < 3; i++)
        {
            square = board[0, i];
            if (square != 0)
            {
                for (j = 0; j < 3; j++)
                    if (board[j, i] != square) break;
                if (j == 3) return square;
            }
        }
        square = board[0, 0];
        if (square != 0)
        {
            for (i = 0; i < 3; i++)
            {
                if (board[i, i] != square) break;
            }
            if (i == 3) return square;
        }
        square = board[0, 3 - 1];
        if (square != 0)
        {
            for (i = 0; i < 3; i++)
            {
                if (board[i, 3 - i - 1] != square) break;
            }
            if (i == 3) return square;
        }
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            { if (board[i, j] == 0) break; }
            if (j != 3) break;
        }
        if (j == 3 && i == 3) return 0;//the game ended and they tied
        else
            return 10;//it did not end
    }
    private int bmove1(int n, int player, ref int row, ref int col)
    {
        int i, j = -1, r, c, bcond, tmr = -1, tmc = -1, tmcond = -1, test;
        for (i = 0; i < 3; i++)//check if the board is empty
        {
            for (j = 0; j < 3; j++)
                if (board[i, j] == 0) break;
            if (j != 3) break;
        }
        if (i == 3 && j == 3) return whowon();
        r = i;//assume it is the best square
        c = j;
        board[i, j] = player;
        bcond = whowon();
        board[i, j] = 0;

        for (i = 0; i < 3; i++)//assume it will end in one move
        {
            for (j = 0; j < 3; j++)
            {
                if (board[i, j] == 0)
                {
                    board[i, j] = player;
                    test = whowon();
                    board[i, j] = 0;

                    if (test == player)//winning square
                    {

                        row = i;
                        col = j;
                        return test;
                    }
                    if (test == 0)//tie
                    {
                        tmr = i;
                        tmc = j;
                        tmcond = test;
                    }
                }
            }
        }

        if (tmr != -1 || tmc != -1)//will end the game but not with a win
        {
            row = tmr;
            col = tmc;
            return tmcond;//tmr,tmc,tmcond finished their job with one square condition
        }
        else//did not find a tie or win hence does not end in 1 move
        {
            if (n == 10)//reached the limit
            {
                row = r;//the first square values
                col = c;
                return bcond;
            }
            for (i = 0; i < 3; i++)//the recursion part
            {
                for (j = 0; j < 3; j++)
                {
                    if (board[i, j] == 0)
                    {
                        board[i, j] = player;
                        tmcond = bmove1(n + 1, -player, ref tmr, ref tmc);
                        board[i, j] = 0;
                        if (tmcond == player)//enemy's best move will lead to my win
                        {
                            row = i;
                            col = j;
                            return tmcond;
                        }
                        else
                        {
                            if ((tmcond == 0 || tmcond == -player) && bcond == 10)
                            {
                                r = i;
                                c = j;
                                bcond = tmcond;
                            }
                            if ((tmcond == 0 || tmcond == 10) && bcond == -player)
                            {
                                r = i;
                                c = j;
                                bcond = tmcond;
                            }
                        }
                    }
                }
            }//stored best move -if not send it- in r,c,bcond
            row = r;
            col = c;
            return bcond;
        }
    }
    private void bmove()
    {
        int row = -1, col = -1, p;
        if (player.Text.CompareTo("X") == 0)
            p = -1;
        else
            p = 1;
        bmove1(1, p, ref row, ref col);
        board[row, col] = p;
    }
    private void print()
    {
        l00.Text = board_value(board[0, 0]);
        l01.Text = board_value(board[0, 1]);
        l02.Text = board_value(board[0, 2]);

        l10.Text = board_value(board[1, 0]);
        l11.Text = board_value(board[1, 1]);
        l12.Text = board_value(board[1, 2]);

        l20.Text = board_value(board[2, 0]);
        l21.Text = board_value(board[2, 1]);
        l22.Text = board_value(board[2, 2]);
       
    }
    /* class Move
     { for future stack
         public int Row { get; set; }
         public int Col { get; set; }
     } */


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Button1.Text.CompareTo("PLAY") ==0)
        {
            Button1.Text = "RESET";
            DropDownList1.Visible = false;
            
            player.Text = DropDownList1.Text;
            ContentPlaceHolder cph = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    ((Button)cph.FindControl("l" + i + j)).Visible = true;
                }
        }else if(Button1.Text.CompareTo("RESET") ==0)
        {
            Button1.Text = "PLAY";
            DropDownList1.Visible = true;
            player.Text = " ";
            score.Text = " ";
            score.Visible = false;
            ContentPlaceHolder cph = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    ((Button)cph.FindControl("l" + i + j)).Visible = false;
                    ((Button)cph.FindControl("l" + i + j)).Text = " ";
                }
        }
    }
}