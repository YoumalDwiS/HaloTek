namespace TesterProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAdmin = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnKasir = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnKepala = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnKeluar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAdmin.color = System.Drawing.Color.SeaGreen;
            this.btnAdmin.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImagePosition = 18;
            this.btnAdmin.ImageZoom = 50;
            this.btnAdmin.LabelPosition = 36;
            this.btnAdmin.LabelText = "Admin";
            this.btnAdmin.Location = new System.Drawing.Point(263, 329);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 102);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // btnKasir
            // 
            this.btnKasir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKasir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnKasir.color = System.Drawing.Color.SeaGreen;
            this.btnKasir.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnKasir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKasir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKasir.ForeColor = System.Drawing.Color.White;
            this.btnKasir.Image = ((System.Drawing.Image)(resources.GetObject("btnKasir.Image")));
            this.btnKasir.ImagePosition = 18;
            this.btnKasir.ImageZoom = 50;
            this.btnKasir.LabelPosition = 36;
            this.btnKasir.LabelText = "Kasir";
            this.btnKasir.Location = new System.Drawing.Point(480, 329);
            this.btnKasir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnKasir.Name = "btnKasir";
            this.btnKasir.Size = new System.Drawing.Size(100, 102);
            this.btnKasir.TabIndex = 5;
            // 
            // btnKepala
            // 
            this.btnKepala.BackColor = System.Drawing.Color.SeaGreen;
            this.btnKepala.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnKepala.color = System.Drawing.Color.SeaGreen;
            this.btnKepala.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnKepala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKepala.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKepala.ForeColor = System.Drawing.Color.White;
            this.btnKepala.Image = ((System.Drawing.Image)(resources.GetObject("btnKepala.Image")));
            this.btnKepala.ImagePosition = 18;
            this.btnKepala.ImageZoom = 50;
            this.btnKepala.LabelPosition = 36;
            this.btnKepala.LabelText = "Kepala";
            this.btnKepala.Location = new System.Drawing.Point(692, 329);
            this.btnKepala.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnKepala.Name = "btnKepala";
            this.btnKepala.Size = new System.Drawing.Size(100, 102);
            this.btnKepala.TabIndex = 6;
            // 
            // btnKeluar
            // 
            this.btnKeluar.AllowAnimations = true;
            this.btnKeluar.AllowMouseEffects = true;
            this.btnKeluar.AllowToggling = false;
            this.btnKeluar.AnimationSpeed = 200;
            this.btnKeluar.AutoGenerateColors = false;
            this.btnKeluar.AutoRoundBorders = false;
            this.btnKeluar.AutoSizeLeftIcon = true;
            this.btnKeluar.AutoSizeRightIcon = true;
            this.btnKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btnKeluar.BackColor1 = System.Drawing.Color.SeaGreen;
            this.btnKeluar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKeluar.BackgroundImage")));
            this.btnKeluar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnKeluar.ButtonText = "Keluar";
            this.btnKeluar.ButtonTextMarginLeft = 0;
            this.btnKeluar.ColorContrastOnClick = 45;
            this.btnKeluar.ColorContrastOnHover = 45;
            this.btnKeluar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnKeluar.CustomizableEdges = borderEdges6;
            this.btnKeluar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKeluar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnKeluar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnKeluar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnKeluar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnKeluar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKeluar.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnKeluar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnKeluar.IconMarginLeft = 11;
            this.btnKeluar.IconPadding = 10;
            this.btnKeluar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeluar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnKeluar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnKeluar.IconSize = 25;
            this.btnKeluar.IdleBorderColor = System.Drawing.Color.SeaGreen;
            this.btnKeluar.IdleBorderRadius = 1;
            this.btnKeluar.IdleBorderThickness = 1;
            this.btnKeluar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnKeluar.IdleIconLeftImage = null;
            this.btnKeluar.IdleIconRightImage = null;
            this.btnKeluar.IndicateFocus = false;
            this.btnKeluar.Location = new System.Drawing.Point(480, 491);
            this.btnKeluar.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnKeluar.OnDisabledState.BorderRadius = 1;
            this.btnKeluar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnKeluar.OnDisabledState.BorderThickness = 1;
            this.btnKeluar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnKeluar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnKeluar.OnDisabledState.IconLeftImage = null;
            this.btnKeluar.OnDisabledState.IconRightImage = null;
            this.btnKeluar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnKeluar.onHoverState.BorderRadius = 1;
            this.btnKeluar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnKeluar.onHoverState.BorderThickness = 1;
            this.btnKeluar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnKeluar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.onHoverState.IconLeftImage = null;
            this.btnKeluar.onHoverState.IconRightImage = null;
            this.btnKeluar.OnIdleState.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnKeluar.OnIdleState.BorderRadius = 1;
            this.btnKeluar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dash;
            this.btnKeluar.OnIdleState.BorderThickness = 1;
            this.btnKeluar.OnIdleState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnKeluar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.OnIdleState.IconLeftImage = null;
            this.btnKeluar.OnIdleState.IconRightImage = null;
            this.btnKeluar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnKeluar.OnPressedState.BorderRadius = 1;
            this.btnKeluar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnKeluar.OnPressedState.BorderThickness = 1;
            this.btnKeluar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnKeluar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.OnPressedState.IconLeftImage = null;
            this.btnKeluar.OnPressedState.IconRightImage = null;
            this.btnKeluar.Size = new System.Drawing.Size(101, 48);
            this.btnKeluar.TabIndex = 7;
            this.btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKeluar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKeluar.TextMarginLeft = 0;
            this.btnKeluar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnKeluar.UseDefaultRadiusAndThickness = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TesterProject.Properties.Resources.BgMainForm_HaloTek;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnKepala);
            this.Controls.Add(this.btnKasir);
            this.Controls.Add(this.btnAdmin);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnKeluar;
        private Bunifu.Framework.UI.BunifuTileButton btnKepala;
        private Bunifu.Framework.UI.BunifuTileButton btnKasir;
        private Bunifu.Framework.UI.BunifuTileButton btnAdmin;
    }
}

