namespace JobSystem.Reporting.ReportDefinitions
{
	partial class TelerikConsignmentReport
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for telerik Reporting designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
			Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
			Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
			Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
			this.pageHeader = new Telerik.Reporting.PageHeaderSection();
			this.pageFooter = new Telerik.Reporting.PageFooterSection();
			this.currentTimeTextBox = new Telerik.Reporting.TextBox();
			this.pageInfoTextBox = new Telerik.Reporting.TextBox();
			this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
			this.shape2 = new Telerik.Reporting.Shape();
			this.titleTextBox = new Telerik.Reporting.TextBox();
			this.consignmentNoDataTextBox = new Telerik.Reporting.TextBox();
			this.supplierNameDataTextBox = new Telerik.Reporting.TextBox();
			this.supplierAddress1DataTextBox = new Telerik.Reporting.TextBox();
			this.supplierAddress2DataTextBox = new Telerik.Reporting.TextBox();
			this.supplierAddress3DataTextBox = new Telerik.Reporting.TextBox();
			this.supplierAddress4DataTextBox = new Telerik.Reporting.TextBox();
			this.supplierAddress5DataTextBox = new Telerik.Reporting.TextBox();
			this.raisedByDataTextBox = new Telerik.Reporting.TextBox();
			this.dateCreatedDataTextBox = new Telerik.Reporting.TextBox();
			this.textBox1 = new Telerik.Reporting.TextBox();
			this.textBox2 = new Telerik.Reporting.TextBox();
			this.textBox3 = new Telerik.Reporting.TextBox();
			this.textBox4 = new Telerik.Reporting.TextBox();
			this.textBox5 = new Telerik.Reporting.TextBox();
			this.textBox6 = new Telerik.Reporting.TextBox();
			this.MainLogo = new Telerik.Reporting.PictureBox();
			this.shape1 = new Telerik.Reporting.Shape();
			this.textBox7 = new Telerik.Reporting.TextBox();
			this.textBox8 = new Telerik.Reporting.TextBox();
			this.reportFooter = new Telerik.Reporting.ReportFooterSection();
			this.detail = new Telerik.Reporting.DetailSection();
			this.jobRefDataTextBox1 = new Telerik.Reporting.TextBox();
			this.descriptionDataTextBox = new Telerik.Reporting.TextBox();
			this.instructionsDataTextBox = new Telerik.Reporting.TextBox();
			this.shape3 = new Telerik.Reporting.Shape();
			this.textBox9 = new Telerik.Reporting.TextBox();
			this.shape4 = new Telerik.Reporting.Shape();
			this.textBox10 = new Telerik.Reporting.TextBox();
			this.textBox11 = new Telerik.Reporting.TextBox();
			this.shape5 = new Telerik.Reporting.Shape();
			this.textBox12 = new Telerik.Reporting.TextBox();
			this.textBox13 = new Telerik.Reporting.TextBox();
			this.shape6 = new Telerik.Reporting.Shape();
			this.textBox14 = new Telerik.Reporting.TextBox();
			this.textBox15 = new Telerik.Reporting.TextBox();
			this.shape7 = new Telerik.Reporting.Shape();
			this.shape8 = new Telerik.Reporting.Shape();
			this.ReportData = new Telerik.Reporting.ObjectDataSource();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// pageHeader
			// 
			this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
			this.pageHeader.Name = "pageHeader";
			// 
			// pageFooter
			// 
			this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
			this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
			this.pageFooter.Name = "pageFooter";
			// 
			// currentTimeTextBox
			// 
			this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.currentTimeTextBox.Name = "currentTimeTextBox";
			this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
			this.currentTimeTextBox.Style.Font.Name = "Arial";
			this.currentTimeTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.currentTimeTextBox.StyleName = "PageInfo";
			this.currentTimeTextBox.Value = "=NOW()";
			// 
			// pageInfoTextBox
			// 
			this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
			this.pageInfoTextBox.Name = "pageInfoTextBox";
			this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8093647956848145D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
			this.pageInfoTextBox.Style.Font.Name = "Arial";
			this.pageInfoTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
			this.pageInfoTextBox.StyleName = "PageInfo";
			this.pageInfoTextBox.Value = "=PageNumber";
			// 
			// reportHeader
			// 
			this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(7.7856249809265137D);
			this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.shape8,
            this.shape7,
            this.shape3,
            this.shape2,
            this.titleTextBox,
            this.consignmentNoDataTextBox,
            this.supplierNameDataTextBox,
            this.supplierAddress1DataTextBox,
            this.supplierAddress2DataTextBox,
            this.supplierAddress3DataTextBox,
            this.supplierAddress4DataTextBox,
            this.supplierAddress5DataTextBox,
            this.raisedByDataTextBox,
            this.dateCreatedDataTextBox,
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox4,
            this.textBox5,
            this.textBox6,
            this.MainLogo,
            this.shape1,
            this.textBox7,
            this.textBox8,
            this.shape5,
            this.textBox12,
            this.textBox13,
            this.shape6,
            this.textBox14,
            this.textBox15});
			this.reportHeader.Name = "reportHeader";
			// 
			// shape2
			// 
			this.shape2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(200.31494140625D), Telerik.Reporting.Drawing.Unit.Pixel(127.96063232421875D));
			this.shape2.Name = "shape2";
			this.shape2.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(177.63786315917969D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape2.Stretch = true;
			this.shape2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// titleTextBox
			// 
			this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.6001996994018555D), Telerik.Reporting.Drawing.Unit.Cm(1.6249431371688843D));
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1926026344299316D), Telerik.Reporting.Drawing.Unit.Cm(0.88562500476837158D));
			this.titleTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.titleTextBox.Style.Font.Name = "Arial";
			this.titleTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16D);
			this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.titleTextBox.StyleName = "Title";
			this.titleTextBox.Value = "Consignment";
			// 
			// consignmentNoDataTextBox
			// 
			this.consignmentNoDataTextBox.CanGrow = true;
			this.consignmentNoDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.500000953674316D), Telerik.Reporting.Drawing.Unit.Cm(1.6250432729721069D));
			this.consignmentNoDataTextBox.Name = "consignmentNoDataTextBox";
			this.consignmentNoDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.2426068782806396D), Telerik.Reporting.Drawing.Unit.Cm(0.88552480936050415D));
			this.consignmentNoDataTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.consignmentNoDataTextBox.Style.Font.Name = "Arial";
			this.consignmentNoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16D);
			this.consignmentNoDataTextBox.StyleName = "Data";
			this.consignmentNoDataTextBox.Value = "=Fields.ConsignmentNo";
			// 
			// supplierNameDataTextBox
			// 
			this.supplierNameDataTextBox.CanGrow = true;
			this.supplierNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Cm(3.7854244709014893D));
			this.supplierNameDataTextBox.Name = "supplierNameDataTextBox";
			this.supplierNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8612504005432129D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierNameDataTextBox.Style.Font.Bold = true;
			this.supplierNameDataTextBox.Style.Font.Name = "Arial";
			this.supplierNameDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierNameDataTextBox.StyleName = "Data";
			this.supplierNameDataTextBox.Value = "=Fields.SupplierName";
			// 
			// supplierAddress1DataTextBox
			// 
			this.supplierAddress1DataTextBox.CanGrow = true;
			this.supplierAddress1DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Cm(4.2896318435668945D));
			this.supplierAddress1DataTextBox.Name = "supplierAddress1DataTextBox";
			this.supplierAddress1DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8612489700317383D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierAddress1DataTextBox.Style.Font.Bold = true;
			this.supplierAddress1DataTextBox.Style.Font.Name = "Arial";
			this.supplierAddress1DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierAddress1DataTextBox.StyleName = "Data";
			this.supplierAddress1DataTextBox.Value = "=Fields.SupplierAddress1";
			// 
			// supplierAddress2DataTextBox
			// 
			this.supplierAddress2DataTextBox.CanGrow = true;
			this.supplierAddress2DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Cm(4.7938389778137207D));
			this.supplierAddress2DataTextBox.Name = "supplierAddress2DataTextBox";
			this.supplierAddress2DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8612489700317383D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierAddress2DataTextBox.Style.Font.Bold = true;
			this.supplierAddress2DataTextBox.Style.Font.Name = "Arial";
			this.supplierAddress2DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierAddress2DataTextBox.StyleName = "Data";
			this.supplierAddress2DataTextBox.Value = "=Fields.SupplierAddress2";
			// 
			// supplierAddress3DataTextBox
			// 
			this.supplierAddress3DataTextBox.CanGrow = true;
			this.supplierAddress3DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Cm(5.2980465888977051D));
			this.supplierAddress3DataTextBox.Name = "supplierAddress3DataTextBox";
			this.supplierAddress3DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8612499237060547D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierAddress3DataTextBox.Style.Font.Bold = true;
			this.supplierAddress3DataTextBox.Style.Font.Name = "Arial";
			this.supplierAddress3DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierAddress3DataTextBox.StyleName = "Data";
			this.supplierAddress3DataTextBox.Value = "=Fields.SupplierAddress3";
			// 
			// supplierAddress4DataTextBox
			// 
			this.supplierAddress4DataTextBox.CanGrow = true;
			this.supplierAddress4DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Cm(5.8022537231445312D));
			this.supplierAddress4DataTextBox.Name = "supplierAddress4DataTextBox";
			this.supplierAddress4DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8612489700317383D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierAddress4DataTextBox.Style.Font.Bold = true;
			this.supplierAddress4DataTextBox.Style.Font.Name = "Arial";
			this.supplierAddress4DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierAddress4DataTextBox.StyleName = "Data";
			this.supplierAddress4DataTextBox.Value = "=Fields.SupplierAddress4";
			// 
			// supplierAddress5DataTextBox
			// 
			this.supplierAddress5DataTextBox.CanGrow = true;
			this.supplierAddress5DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Cm(6.3064613342285156D));
			this.supplierAddress5DataTextBox.Name = "supplierAddress5DataTextBox";
			this.supplierAddress5DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8612489700317383D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierAddress5DataTextBox.Style.Font.Bold = true;
			this.supplierAddress5DataTextBox.Style.Font.Name = "Arial";
			this.supplierAddress5DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierAddress5DataTextBox.StyleName = "Data";
			this.supplierAddress5DataTextBox.Value = "=Fields.SupplierAddress5";
			// 
			// raisedByDataTextBox
			// 
			this.raisedByDataTextBox.CanGrow = true;
			this.raisedByDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.2999992370605469D), Telerik.Reporting.Drawing.Unit.Cm(4.2856249809265137D));
			this.raisedByDataTextBox.Name = "raisedByDataTextBox";
			this.raisedByDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7000012397766113D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
			this.raisedByDataTextBox.Style.Font.Name = "Arial";
			this.raisedByDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.raisedByDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.raisedByDataTextBox.StyleName = "Data";
			this.raisedByDataTextBox.Value = "=Fields.RaisedBy";
			// 
			// dateCreatedDataTextBox
			// 
			this.dateCreatedDataTextBox.CanGrow = true;
			this.dateCreatedDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.80000114440918D), Telerik.Reporting.Drawing.Unit.Cm(4.2856254577636719D));
			this.dateCreatedDataTextBox.Name = "dateCreatedDataTextBox";
			this.dateCreatedDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.936030387878418D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
			this.dateCreatedDataTextBox.Style.Font.Name = "Arial";
			this.dateCreatedDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.dateCreatedDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.dateCreatedDataTextBox.StyleName = "Data";
			this.dateCreatedDataTextBox.Value = "=Fields.DateCreated";
			// 
			// textBox1
			// 
			this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.9999990463256836D), Telerik.Reporting.Drawing.Unit.Cm(0.056943390518426895D));
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.599998950958252D), Telerik.Reporting.Drawing.Unit.Cm(0.38452392816543579D));
			this.textBox1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
			this.textBox1.Value = "=Fields.CompanyName";
			// 
			// textBox2
			// 
			this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5D), Telerik.Reporting.Drawing.Unit.Cm(0.44146731495857239D));
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.599998950958252D), Telerik.Reporting.Drawing.Unit.Cm(0.38452392816543579D));
			this.textBox2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
			this.textBox2.Value = "=Fields.CompanyAddress1";
			// 
			// textBox3
			// 
			this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5D), Telerik.Reporting.Drawing.Unit.Cm(0.82599121332168579D));
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5999984741210938D), Telerik.Reporting.Drawing.Unit.Cm(0.38452315330505371D));
			this.textBox3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
			this.textBox3.Value = "=Fields.CompanyAddress2";
			// 
			// textBox4
			// 
			this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.9999990463256836D), Telerik.Reporting.Drawing.Unit.Cm(1.2105143070220947D));
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6000001430511475D), Telerik.Reporting.Drawing.Unit.Cm(0.38452315330505371D));
			this.textBox4.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
			this.textBox4.Value = "=Fields.CompanyAddress3";
			// 
			// textBox5
			// 
			this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5D), Telerik.Reporting.Drawing.Unit.Cm(1.5950374603271484D));
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5999984741210938D), Telerik.Reporting.Drawing.Unit.Cm(0.38452392816543579D));
			this.textBox5.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.textBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
			this.textBox5.Value = "=Fields.CompanyAddress4";
			// 
			// textBox6
			// 
			this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5D), Telerik.Reporting.Drawing.Unit.Cm(1.9795613288879395D));
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6000001430511475D), Telerik.Reporting.Drawing.Unit.Cm(0.38452315330505371D));
			this.textBox6.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.textBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
			this.textBox6.Value = "=Fields.CompanyAddress5";
			// 
			// MainLogo
			// 
			this.MainLogo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(2D), Telerik.Reporting.Drawing.Unit.Pixel(2.152191162109375D));
			this.MainLogo.Name = "MainLogo";
			this.MainLogo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(179.41732788085938D), Telerik.Reporting.Drawing.Unit.Pixel(111.26771545410156D));
			// 
			// shape1
			// 
			this.shape1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(0D), Telerik.Reporting.Drawing.Unit.Pixel(116.62205505371094D));
			this.shape1.Name = "shape1";
			this.shape1.ShapeType = new Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW);
			this.shape1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(594.9962158203125D), Telerik.Reporting.Drawing.Unit.Pixel(22.669601440429688D));
			this.shape1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			this.shape1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1D);
			// 
			// textBox7
			// 
			this.textBox7.Angle = 0D;
			this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(200.31497192382813D), Telerik.Reporting.Drawing.Unit.Pixel(139.29164123535156D));
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(177.63780212402344D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
			this.textBox7.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox7.Style.Font.Bold = true;
			this.textBox7.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
			this.textBox7.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5D);
			this.textBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox7.Value = "PREPARED BY";
			// 
			// textBox8
			// 
			this.textBox8.Angle = 0D;
			this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(521.31494140625D), Telerik.Reporting.Drawing.Unit.Pixel(139.29922485351563D));
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(73.432662963867188D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
			this.textBox8.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox8.Style.Font.Bold = true;
			this.textBox8.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
			this.textBox8.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5D);
			this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox8.Value = "DATE";
			// 
			// reportFooter
			// 
			this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
			this.reportFooter.Name = "reportFooter";
			// 
			// detail
			// 
			this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(2.1999998092651367D);
			this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.jobRefDataTextBox1,
            this.descriptionDataTextBox,
            this.instructionsDataTextBox,
            this.textBox9,
            this.shape4,
            this.textBox10,
            this.textBox11});
			this.detail.Name = "detail";
			// 
			// jobRefDataTextBox1
			// 
			this.jobRefDataTextBox1.CanGrow = true;
			this.jobRefDataTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Cm(1.2000001668930054D));
			this.jobRefDataTextBox1.Name = "jobRefDataTextBox1";
			this.jobRefDataTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2000000476837158D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
			this.jobRefDataTextBox1.Style.Font.Name = "Arial";
			this.jobRefDataTextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
			this.jobRefDataTextBox1.StyleName = "Data";
			this.jobRefDataTextBox1.Value = "=Fields.JobRef";
			// 
			// descriptionDataTextBox
			// 
			this.descriptionDataTextBox.CanGrow = true;
			this.descriptionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.5D), Telerik.Reporting.Drawing.Unit.Cm(1.2000001668930054D));
			this.descriptionDataTextBox.Name = "descriptionDataTextBox";
			this.descriptionDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.0345826148986816D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
			this.descriptionDataTextBox.Style.Font.Name = "Arial";
			this.descriptionDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
			this.descriptionDataTextBox.StyleName = "Data";
			this.descriptionDataTextBox.Value = "=Fields.Description";
			// 
			// instructionsDataTextBox
			// 
			this.instructionsDataTextBox.CanGrow = true;
			this.instructionsDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.7002019882202148D), Telerik.Reporting.Drawing.Unit.Cm(1.2000001668930054D));
			this.instructionsDataTextBox.Name = "instructionsDataTextBox";
			this.instructionsDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.04240608215332D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
			this.instructionsDataTextBox.Style.Font.Name = "Arial";
			this.instructionsDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
			this.instructionsDataTextBox.StyleName = "Data";
			this.instructionsDataTextBox.Value = "=Fields.Instructions";
			// 
			// shape3
			// 
			this.shape3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(521.31494140625D), Telerik.Reporting.Drawing.Unit.Pixel(127.96063232421875D));
			this.shape3.Name = "shape3";
			this.shape3.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(73.43267822265625D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape3.Stretch = true;
			this.shape3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// textBox9
			// 
			this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(7.5590629577636719D), Telerik.Reporting.Drawing.Unit.Pixel(15.121917724609375D));
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(83.14959716796875D), Telerik.Reporting.Drawing.Unit.Pixel(22.677154541015625D));
			this.textBox9.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox9.Style.Font.Bold = true;
			this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.textBox9.Value = "ITEM NO.";
			// 
			// shape4
			// 
			this.shape4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(2D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
			this.shape4.Name = "shape4";
			this.shape4.ShapeType = new Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW);
			this.shape4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(594.9962158203125D), Telerik.Reporting.Drawing.Unit.Pixel(22.669601440429688D));
			this.shape4.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			this.shape4.Style.Font.Bold = false;
			this.shape4.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.5D);
			// 
			// textBox10
			// 
			this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(94.488189697265625D), Telerik.Reporting.Drawing.Unit.Pixel(15.121917724609375D));
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(228.07870483398438D), Telerik.Reporting.Drawing.Unit.Pixel(22.677154541015625D));
			this.textBox10.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox10.Style.Font.Bold = true;
			this.textBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.textBox10.Value = "DESCRIPTION";
			// 
			// textBox11
			// 
			this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(328.8265380859375D), Telerik.Reporting.Drawing.Unit.Pixel(15.118133544921875D));
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(266.169677734375D), Telerik.Reporting.Drawing.Unit.Pixel(22.677154541015625D));
			this.textBox11.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox11.Style.Font.Bold = true;
			this.textBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.textBox11.Value = "INSTRUCTIONS";
			// 
			// shape5
			// 
			this.shape5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(377.31500244140625D), Telerik.Reporting.Drawing.Unit.Pixel(127.96063232421875D));
			this.shape5.Name = "shape5";
			this.shape5.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(143.60687255859375D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape5.Stretch = true;
			this.shape5.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// textBox12
			// 
			this.textBox12.Angle = 0D;
			this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(377.96038818359375D), Telerik.Reporting.Drawing.Unit.Pixel(139.29922485351563D));
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(143.60685729980469D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
			this.textBox12.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox12.Style.Font.Bold = true;
			this.textBox12.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
			this.textBox12.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5D);
			this.textBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox12.Value = "SIGNED";
			// 
			// textBox13
			// 
			this.textBox13.Angle = 0D;
			this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(377.31497192382812D), Telerik.Reporting.Drawing.Unit.Pixel(203.55117797851563D));
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(143.60685729980469D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
			this.textBox13.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox13.Style.Font.Bold = true;
			this.textBox13.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
			this.textBox13.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5D);
			this.textBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox13.Value = "SIGNED";
			// 
			// shape6
			// 
			this.shape6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(377.31497192382812D), Telerik.Reporting.Drawing.Unit.Pixel(191.55117797851563D));
			this.shape6.Name = "shape6";
			this.shape6.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(143.60687255859375D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape6.Stretch = true;
			this.shape6.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// textBox14
			// 
			this.textBox14.Angle = 0D;
			this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(521.31494140625D), Telerik.Reporting.Drawing.Unit.Pixel(203.55117797851563D));
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(73.432662963867188D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
			this.textBox14.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox14.Style.Font.Bold = true;
			this.textBox14.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
			this.textBox14.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5D);
			this.textBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox14.Value = "DATE";
			// 
			// textBox15
			// 
			this.textBox15.Angle = 0D;
			this.textBox15.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(200.31497192382813D), Telerik.Reporting.Drawing.Unit.Pixel(203.55117797851563D));
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(177.63780212402344D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
			this.textBox15.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox15.Style.Font.Bold = true;
			this.textBox15.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
			this.textBox15.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5D);
			this.textBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox15.Value = "RECEIEVED BY";
			// 
			// shape7
			// 
			this.shape7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(200.31497192382813D), Telerik.Reporting.Drawing.Unit.Pixel(191.55117797851563D));
			this.shape7.Name = "shape7";
			this.shape7.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(177.63786315917969D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape7.Stretch = true;
			this.shape7.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// shape8
			// 
			this.shape8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(521.31494140625D), Telerik.Reporting.Drawing.Unit.Pixel(191.55117797851563D));
			this.shape8.Name = "shape8";
			this.shape8.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(73.43267822265625D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape8.Stretch = true;
			this.shape8.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// ReportData
			// 
			this.ReportData.DataMember = "GetConsignmentReportData";
			this.ReportData.DataSource = typeof(JobSystem.Reporting.Data.NHibernate.NHibernateConsignmentReportDataProvider);
			this.ReportData.Name = "ReportData";
			this.ReportData.Parameters.AddRange(new Telerik.Reporting.ObjectDataSourceParameter[] {
            new Telerik.Reporting.ObjectDataSourceParameter("consignmentId", typeof(System.Guid), null)});
			// 
			// TelerikConsignmentReport
			// 
			this.DataSource = this.ReportData;
			this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
			this.Name = "TelerikConsignmentReport";
			this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D);
			this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D);
			this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D);
			this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D);
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.Style.BackgroundColor = System.Drawing.Color.White;
			this.Style.Font.Bold = false;
			this.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.Style.Font.Strikeout = false;
			styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
			styleRule1.Style.Color = System.Drawing.Color.Black;
			styleRule1.Style.Font.Bold = true;
			styleRule1.Style.Font.Italic = false;
			styleRule1.Style.Font.Name = "Tahoma";
			styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(20D);
			styleRule1.Style.Font.Strikeout = false;
			styleRule1.Style.Font.Underline = false;
			styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
			styleRule2.Style.Color = System.Drawing.Color.Black;
			styleRule2.Style.Font.Name = "Tahoma";
			styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
			styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
			styleRule3.Style.Font.Name = "Tahoma";
			styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
			styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
			styleRule4.Style.Font.Name = "Tahoma";
			styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
			styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
			this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Pixel;
			this.Width = Telerik.Reporting.Drawing.Unit.Pixel(595D);
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion

		private Telerik.Reporting.ObjectDataSource ReportData;
		private Telerik.Reporting.PageHeaderSection pageHeader;
		private Telerik.Reporting.PageFooterSection pageFooter;
		private Telerik.Reporting.TextBox currentTimeTextBox;
		private Telerik.Reporting.TextBox pageInfoTextBox;
		private Telerik.Reporting.ReportHeaderSection reportHeader;
		private Telerik.Reporting.TextBox titleTextBox;
		private Telerik.Reporting.TextBox consignmentNoDataTextBox;
		private Telerik.Reporting.TextBox supplierNameDataTextBox;
		private Telerik.Reporting.TextBox supplierAddress1DataTextBox;
		private Telerik.Reporting.TextBox supplierAddress2DataTextBox;
		private Telerik.Reporting.TextBox supplierAddress3DataTextBox;
		private Telerik.Reporting.TextBox supplierAddress4DataTextBox;
		private Telerik.Reporting.TextBox supplierAddress5DataTextBox;
		private Telerik.Reporting.TextBox raisedByDataTextBox;
		private Telerik.Reporting.TextBox dateCreatedDataTextBox;
		private Telerik.Reporting.ReportFooterSection reportFooter;
		private Telerik.Reporting.DetailSection detail;
		private Telerik.Reporting.TextBox jobRefDataTextBox1;
		private Telerik.Reporting.TextBox descriptionDataTextBox;
		private Telerik.Reporting.TextBox instructionsDataTextBox;
		private Telerik.Reporting.TextBox textBox1;
		private Telerik.Reporting.TextBox textBox2;
		private Telerik.Reporting.TextBox textBox3;
		private Telerik.Reporting.TextBox textBox4;
		private Telerik.Reporting.TextBox textBox5;
		private Telerik.Reporting.TextBox textBox6;
		private Telerik.Reporting.Shape shape1;
		private Telerik.Reporting.TextBox textBox7;
		public Telerik.Reporting.PictureBox MainLogo;
		private Telerik.Reporting.Shape shape2;
		private Telerik.Reporting.TextBox textBox8;
		private Telerik.Reporting.Shape shape3;
		private Telerik.Reporting.TextBox textBox9;
		private Telerik.Reporting.Shape shape4;
		private Telerik.Reporting.TextBox textBox10;
		private Telerik.Reporting.TextBox textBox11;
		private Telerik.Reporting.Shape shape5;
		private Telerik.Reporting.TextBox textBox12;
		private Telerik.Reporting.Shape shape8;
		private Telerik.Reporting.Shape shape7;
		private Telerik.Reporting.TextBox textBox13;
		private Telerik.Reporting.Shape shape6;
		private Telerik.Reporting.TextBox textBox14;
		private Telerik.Reporting.TextBox textBox15;

	}
}