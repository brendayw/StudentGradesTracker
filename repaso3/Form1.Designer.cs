
namespace repaso3
{
    partial class FNotas
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
            this.NUDNotas = new System.Windows.Forms.NumericUpDown();
            this.labelNota = new System.Windows.Forms.Label();
            this.bIniciar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.labelCantidadNotas = new System.Windows.Forms.Label();
            this.labelCantidadAprobados = new System.Windows.Forms.Label();
            this.labelCantidadPromocion = new System.Windows.Forms.Label();
            this.labelPromedio = new System.Windows.Forms.Label();
            this.labelPorcentajeAprobados = new System.Windows.Forms.Label();
            this.labelPorcentajePromocion = new System.Windows.Forms.Label();
            this.labelPorcentajeDesaprobados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDNotas
            // 
            this.NUDNotas.Location = new System.Drawing.Point(252, 82);
            this.NUDNotas.Name = "NUDNotas";
            this.NUDNotas.Size = new System.Drawing.Size(129, 20);
            this.NUDNotas.TabIndex = 0;
            this.NUDNotas.ValueChanged += new System.EventHandler(this.NUDNotas_ValueChanged);
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(144, 89);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(30, 13);
            this.labelNota.TabIndex = 1;
            this.labelNota.Text = "Nota";
            this.labelNota.Click += new System.EventHandler(this.labelNota_Click);
            // 
            // bIniciar
            // 
            this.bIniciar.Location = new System.Drawing.Point(79, 128);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(146, 36);
            this.bIniciar.TabIndex = 2;
            this.bIniciar.Text = "Iniciar";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(264, 128);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(146, 36);
            this.bAgregar.TabIndex = 3;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // labelCantidadNotas
            // 
            this.labelCantidadNotas.AutoSize = true;
            this.labelCantidadNotas.Location = new System.Drawing.Point(120, 182);
            this.labelCantidadNotas.Name = "labelCantidadNotas";
            this.labelCantidadNotas.Size = new System.Drawing.Size(105, 13);
            this.labelCantidadNotas.TabIndex = 4;
            this.labelCantidadNotas.Text = "Cantidad de notas: 0";
            this.labelCantidadNotas.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCantidadAprobados
            // 
            this.labelCantidadAprobados.AutoSize = true;
            this.labelCantidadAprobados.Location = new System.Drawing.Point(95, 208);
            this.labelCantidadAprobados.Name = "labelCantidadAprobados";
            this.labelCantidadAprobados.Size = new System.Drawing.Size(130, 13);
            this.labelCantidadAprobados.TabIndex = 5;
            this.labelCantidadAprobados.Text = "Cantidad de Aprobados: 0";
            // 
            // labelCantidadPromocion
            // 
            this.labelCantidadPromocion.AutoSize = true;
            this.labelCantidadPromocion.Location = new System.Drawing.Point(96, 233);
            this.labelCantidadPromocion.Name = "labelCantidadPromocion";
            this.labelCantidadPromocion.Size = new System.Drawing.Size(129, 13);
            this.labelCantidadPromocion.TabIndex = 6;
            this.labelCantidadPromocion.Text = "Cantidad en Promocion: 0";
            // 
            // labelPromedio
            // 
            this.labelPromedio.AutoSize = true;
            this.labelPromedio.Location = new System.Drawing.Point(73, 255);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(152, 13);
            this.labelPromedio.TabIndex = 7;
            this.labelPromedio.Text = "Promedio de todas las notas: 0";
            this.labelPromedio.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelPorcentajeAprobados
            // 
            this.labelPorcentajeAprobados.AutoSize = true;
            this.labelPorcentajeAprobados.Location = new System.Drawing.Point(274, 182);
            this.labelPorcentajeAprobados.Name = "labelPorcentajeAprobados";
            this.labelPorcentajeAprobados.Size = new System.Drawing.Size(149, 13);
            this.labelPorcentajeAprobados.TabIndex = 8;
            this.labelPorcentajeAprobados.Text = "Porcentaje de aprobados: 0% ";
            // 
            // labelPorcentajePromocion
            // 
            this.labelPorcentajePromocion.AutoSize = true;
            this.labelPorcentajePromocion.Location = new System.Drawing.Point(274, 208);
            this.labelPorcentajePromocion.Name = "labelPorcentajePromocion";
            this.labelPorcentajePromocion.Size = new System.Drawing.Size(145, 13);
            this.labelPorcentajePromocion.TabIndex = 9;
            this.labelPorcentajePromocion.Text = "Porcentaje en promoción: 0%";
            this.labelPorcentajePromocion.Click += new System.EventHandler(this.labelPorcentajePromocion_Click_2);
            // 
            // labelPorcentajeDesaprobados
            // 
            this.labelPorcentajeDesaprobados.AutoSize = true;
            this.labelPorcentajeDesaprobados.Location = new System.Drawing.Point(274, 233);
            this.labelPorcentajeDesaprobados.Name = "labelPorcentajeDesaprobados";
            this.labelPorcentajeDesaprobados.Size = new System.Drawing.Size(163, 13);
            this.labelPorcentajeDesaprobados.TabIndex = 10;
            this.labelPorcentajeDesaprobados.Text = "Porcentaje de desaprobados: 0%";
            this.labelPorcentajeDesaprobados.Click += new System.EventHandler(this.labelPorcentajeDesaprobados_Click_2);
            // 
            // FNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 306);
            this.Controls.Add(this.labelPorcentajeDesaprobados);
            this.Controls.Add(this.labelPorcentajePromocion);
            this.Controls.Add(this.labelPorcentajeAprobados);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.labelCantidadPromocion);
            this.Controls.Add(this.labelCantidadAprobados);
            this.Controls.Add(this.labelCantidadNotas);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.NUDNotas);
            this.Name = "FNotas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUDNotas;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Label labelCantidadNotas;
        private System.Windows.Forms.Label labelCantidadAprobados;
        private System.Windows.Forms.Label labelCantidadPromocion;
        private System.Windows.Forms.Label labelPromedio;
        private System.Windows.Forms.Label labelPorcentajeAprobados;
        private System.Windows.Forms.Label labelPorcentajePromocion;
        private System.Windows.Forms.Label labelPorcentajeDesaprobados;
    }
}

