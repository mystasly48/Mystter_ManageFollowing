namespace Mystter_ManageFollowing {
  partial class Form1 {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent() {
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // webBrowser1
      // 
      this.webBrowser1.Location = new System.Drawing.Point(-4, 129);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new System.Drawing.Size(1259, 722);
      this.webBrowser1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(228, 38);
      this.button1.TabIndex = 1;
      this.button1.Text = "非アクティブのユーザーを検索";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(920, 65);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(310, 45);
      this.button2.TabIndex = 2;
      this.button2.Text = "@example さんをフォロー解除";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 56);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(228, 38);
      this.progressBar1.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1258, 854);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.webBrowser1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.WebBrowser webBrowser1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ProgressBar progressBar1;
  }
}

