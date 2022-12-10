namespace DemoGoogleTrends
{
    partial class DemoGoogleTrends
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botonGenerarGrafico = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.territorioGoogle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoGoogle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tiempoGoogle = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.botonGenerarGrafico);
            this.groupBox3.Controls.Add(this.grafico);
            this.groupBox3.Controls.Add(this.territorioGoogle);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textoGoogle);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tiempoGoogle);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(8, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(823, 402);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Google Trends:";
            // 
            // botonGenerarGrafico
            // 
            this.botonGenerarGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonGenerarGrafico.BackColor = System.Drawing.Color.Yellow;
            this.botonGenerarGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerarGrafico.ForeColor = System.Drawing.Color.Brown;
            this.botonGenerarGrafico.Location = new System.Drawing.Point(276, 16);
            this.botonGenerarGrafico.Name = "botonGenerarGrafico";
            this.botonGenerarGrafico.Size = new System.Drawing.Size(542, 47);
            this.botonGenerarGrafico.TabIndex = 87;
            this.botonGenerarGrafico.Text = "Generar Grafico";
            this.botonGenerarGrafico.UseVisualStyleBackColor = false;
            this.botonGenerarGrafico.Click += new System.EventHandler(this.botonGenerarGrafico_Click);
            // 
            // grafico
            // 
            this.grafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grafico.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.grafico.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            this.grafico.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.grafico.BorderSkin.BorderWidth = 5;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.Area3DStyle.WallWidth = 3;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Red;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DodgerBlue;
            chartArea1.AxisX.LabelStyle.Interval = 45D;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.LineWidth = 5;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisX.MinorTickMark.LineWidth = 2;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DodgerBlue;
            chartArea1.AxisY.LabelStyle.Interval = 10D;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.LogarithmBase = 5D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.SystemColors.HighlightText;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.CursorX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.Transparent;
            chartArea1.CursorY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.CursorY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.CursorY.SelectionColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.grafico.ChartAreas.Add(chartArea1);
            this.grafico.Location = new System.Drawing.Point(8, 91);
            this.grafico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grafico.Name = "grafico";
            this.grafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.LightSlateGray;
            series1.LabelForeColor = System.Drawing.Color.LightSlateGray;
            series1.Name = "Series1";
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Red;
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(810, 300);
            this.grafico.TabIndex = 86;
            this.grafico.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DodgerBlue;
            title1.Name = "Title1";
            title1.Text = "titulo";
            this.grafico.Titles.Add(title1);
            // 
            // territorioGoogle
            // 
            this.territorioGoogle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.territorioGoogle.FormattingEnabled = true;
            this.territorioGoogle.Items.AddRange(new object[] {
            "NACIONAL",
            "INTERNACIONAL"});
            this.territorioGoogle.Location = new System.Drawing.Point(60, 45);
            this.territorioGoogle.Name = "territorioGoogle";
            this.territorioGoogle.Size = new System.Drawing.Size(97, 21);
            this.territorioGoogle.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Territorio:";
            // 
            // textoGoogle
            // 
            this.textoGoogle.Location = new System.Drawing.Point(98, 18);
            this.textoGoogle.Name = "textoGoogle";
            this.textoGoogle.Size = new System.Drawing.Size(174, 20);
            this.textoGoogle.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Texto busqueda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tiempo:";
            // 
            // tiempoGoogle
            // 
            this.tiempoGoogle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiempoGoogle.FormattingEnabled = true;
            this.tiempoGoogle.Items.AddRange(new object[] {
            "1-d",
            "7-d"});
            this.tiempoGoogle.Location = new System.Drawing.Point(210, 45);
            this.tiempoGoogle.Name = "tiempoGoogle";
            this.tiempoGoogle.Size = new System.Drawing.Size(62, 21);
            this.tiempoGoogle.TabIndex = 12;
            // 
            // DemoGoogleTrends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 423);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DemoGoogleTrends";
            this.Text = "DemoGoogleTrends";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button botonGenerarGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        public System.Windows.Forms.ComboBox territorioGoogle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoGoogle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tiempoGoogle;
    }
}

