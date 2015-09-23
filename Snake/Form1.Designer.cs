
namespace Snake
{
    partial class SnakeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.score = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbGameOver = new System.Windows.Forms.Label();
            this.snakeCanvas = new System.Windows.Forms.PictureBox();
            this.SBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(526, 37);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(83, 29);
            this.score.TabIndex = 1;
            this.score.Text = "Score:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(628, 37);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(19, 29);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = " ";
            // 
            // lbGameOver
            // 
            this.lbGameOver.AutoSize = true;
            this.lbGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameOver.Image = global::Snake.Properties.Resources.Background;
            this.lbGameOver.Location = new System.Drawing.Point(123, 141);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(19, 29);
            this.lbGameOver.TabIndex = 3;
            this.lbGameOver.Text = " ";
            this.lbGameOver.Visible = false;
            // 
            // snakeCanvas
            // 
            this.snakeCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snakeCanvas.Image = global::Snake.Properties.Resources.Background;
            this.snakeCanvas.Location = new System.Drawing.Point(4, 3);
            this.snakeCanvas.Name = "snakeCanvas";
            this.snakeCanvas.Size = new System.Drawing.Size(499, 400);
            this.snakeCanvas.TabIndex = 0;
            this.snakeCanvas.TabStop = false;
            this.snakeCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.snakeCanvas_Paint);
            // 
            // SBoard
            // 
            this.SBoard.BackgroundImage = global::Snake.Properties.Resources.Score_Board;
            this.SBoard.Location = new System.Drawing.Point(505, 3);
            this.SBoard.Name = "SBoard";
            this.SBoard.Size = new System.Drawing.Size(188, 400);
            this.SBoard.TabIndex = 4;
            this.SBoard.TabStop = false;
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(696, 408);
            this.Controls.Add(this.score);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.snakeCanvas);
            this.Controls.Add(this.SBoard);
            this.Name = "SnakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SnakeForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.snakeCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
 

        #endregion

        private System.Windows.Forms.PictureBox snakeCanvas;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lbGameOver;
        private System.Windows.Forms.PictureBox SBoard;
    }
}

