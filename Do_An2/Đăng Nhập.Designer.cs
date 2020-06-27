namespace Do_An2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.But_id = new System.Windows.Forms.TextBox();
            this.But_Pass = new System.Windows.Forms.TextBox();
            this.But_Sign_in = new System.Windows.Forms.Button();
            this.But_Forget_Pass = new System.Windows.Forms.Button();
            this.But_Create_Acc = new System.Windows.Forms.Button();
            this.But_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // But_id
            // 
            resources.ApplyResources(this.But_id, "But_id");
            this.But_id.Name = "But_id";
            // 
            // But_Pass
            // 
            resources.ApplyResources(this.But_Pass, "But_Pass");
            this.But_Pass.Name = "But_Pass";
            // 
            // But_Sign_in
            // 
            resources.ApplyResources(this.But_Sign_in, "But_Sign_in");
            this.But_Sign_in.Name = "But_Sign_in";
            this.But_Sign_in.UseVisualStyleBackColor = true;
            this.But_Sign_in.Click += new System.EventHandler(this.But_Sign_in_Click);
            // 
            // But_Forget_Pass
            // 
            resources.ApplyResources(this.But_Forget_Pass, "But_Forget_Pass");
            this.But_Forget_Pass.Name = "But_Forget_Pass";
            this.But_Forget_Pass.UseVisualStyleBackColor = true;
            this.But_Forget_Pass.Click += new System.EventHandler(this.But_Forget_Pass_Click);
            // 
            // But_Create_Acc
            // 
            resources.ApplyResources(this.But_Create_Acc, "But_Create_Acc");
            this.But_Create_Acc.Name = "But_Create_Acc";
            this.But_Create_Acc.UseVisualStyleBackColor = true;
            this.But_Create_Acc.Click += new System.EventHandler(this.But_Create_Acc_Click);
            // 
            // But_Back
            // 
            resources.ApplyResources(this.But_Back, "But_Back");
            this.But_Back.Name = "But_Back";
            this.But_Back.UseVisualStyleBackColor = true;
            this.But_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.But_Back);
            this.Controls.Add(this.But_Create_Acc);
            this.Controls.Add(this.But_Forget_Pass);
            this.Controls.Add(this.But_Sign_in);
            this.Controls.Add(this.But_Pass);
            this.Controls.Add(this.But_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox But_id;
        private System.Windows.Forms.TextBox But_Pass;
        private System.Windows.Forms.Button But_Sign_in;
        private System.Windows.Forms.Button But_Forget_Pass;
        private System.Windows.Forms.Button But_Create_Acc;
        private System.Windows.Forms.Button But_Back;
    }
}

