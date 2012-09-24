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
			this.pageInfoTextBox = new Telerik.Reporting.TextBox();
			this.textBox1 = new Telerik.Reporting.TextBox();
			this.CompanyAddressTextBox = new Telerik.Reporting.TextBox();
			this.textBox2 = new Telerik.Reporting.TextBox();
			this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
			this.shape6 = new Telerik.Reporting.Shape();
			this.shape8 = new Telerik.Reporting.Shape();
			this.shape7 = new Telerik.Reporting.Shape();
			this.shape3 = new Telerik.Reporting.Shape();
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
			this.MainLogo = new Telerik.Reporting.PictureBox();
			this.textBox7 = new Telerik.Reporting.TextBox();
			this.textBox8 = new Telerik.Reporting.TextBox();
			this.shape5 = new Telerik.Reporting.Shape();
			this.textBox12 = new Telerik.Reporting.TextBox();
			this.textBox13 = new Telerik.Reporting.TextBox();
			this.textBox14 = new Telerik.Reporting.TextBox();
			this.textBox15 = new Telerik.Reporting.TextBox();
			this.textBox11 = new Telerik.Reporting.TextBox();
			this.textBox10 = new Telerik.Reporting.TextBox();
			this.textBox9 = new Telerik.Reporting.TextBox();
			this.shape4 = new Telerik.Reporting.Shape();
			this.reportFooter = new Telerik.Reporting.ReportFooterSection();
			this.detail = new Telerik.Reporting.DetailSection();
			this.jobRefDataTextBox1 = new Telerik.Reporting.TextBox();
			this.descriptionDataTextBox = new Telerik.Reporting.TextBox();
			this.instructionsDataTextBox = new Telerik.Reporting.TextBox();
			this.shape9 = new Telerik.Reporting.Shape();
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
			this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(3.2682242393493652D);
			this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageInfoTextBox,
            this.textBox1,
            this.CompanyAddressTextBox,
            this.textBox2});
			this.pageFooter.Name = "pageFooter";
			// 
			// pageInfoTextBox
			// 
			this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.55699348449707D), Telerik.Reporting.Drawing.Unit.Cm(2.5681264400482178D));
			this.pageInfoTextBox.Name = "pageInfoTextBox";
			this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2429072856903076D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
			this.pageInfoTextBox.Style.Color = System.Drawing.Color.Gray;
			this.pageInfoTextBox.Style.Font.Name = "Arial";
			this.pageInfoTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
			this.pageInfoTextBox.StyleName = "PageInfo";
			this.pageInfoTextBox.Value = "=PageNumber";
			// 
			// textBox1
			// 
			this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666D), Telerik.Reporting.Drawing.Unit.Cm(1.3856251239776611D));
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.799701690673828D), Telerik.Reporting.Drawing.Unit.Cm(0.38452392816543579D));
			this.textBox1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
			this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox1.Value = "=Fields.CompanyName";
			// 
			// CompanyAddressTextBox
			// 
			this.CompanyAddressTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010002215276472271D), Telerik.Reporting.Drawing.Unit.Cm(1.770348072052002D));
			this.CompanyAddressTextBox.Name = "CompanyAddressTextBox";
			this.CompanyAddressTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.799800872802734D), Telerik.Reporting.Drawing.Unit.Cm(0.38452392816543579D));
			this.CompanyAddressTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.CompanyAddressTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.CompanyAddressTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.CompanyAddressTextBox.Value = "= Fields.CompanyAddress";
			// 
			// textBox2
			// 
			this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(2.1550726890563965D));
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.799800872802734D), Telerik.Reporting.Drawing.Unit.Cm(0.38452392816543579D));
			this.textBox2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
			this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox2.Value = "= Fields.CompanyContactInfo";
			// 
			// reportHeader
			// 
			this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(9.2030248641967773D);
			this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.shape6,
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
            this.MainLogo,
            this.textBox7,
            this.textBox8,
            this.shape5,
            this.textBox12,
            this.textBox13,
            this.textBox14,
            this.textBox15,
            this.textBox11,
            this.textBox10,
            this.textBox9,
            this.shape4});
			this.reportHeader.Name = "reportHeader";
			// 
			// shape6
			// 
			this.shape6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(248.80340576171875D), Telerik.Reporting.Drawing.Unit.Pixel(237.56692504882813D));
			this.shape6.Name = "shape6";
			this.shape6.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(234.33074951171875D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape6.Stretch = true;
			this.shape6.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// shape8
			// 
			this.shape8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(483.1417236328125D), Telerik.Reporting.Drawing.Unit.Pixel(237.56692504882813D));
			this.shape8.Name = "shape8";
			this.shape8.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(118.5552978515625D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape8.Stretch = true;
			this.shape8.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// shape7
			// 
			this.shape7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(7.5590629577636719D), Telerik.Reporting.Drawing.Unit.Pixel(237.56692504882813D));
			this.shape7.Name = "shape7";
			this.shape7.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(241.88983154296875D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape7.Stretch = true;
			this.shape7.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// shape3
			// 
			this.shape3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(483.1417236328125D), Telerik.Reporting.Drawing.Unit.Pixel(173.97637939453125D));
			this.shape3.Name = "shape3";
			this.shape3.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(118.5552978515625D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape3.Stretch = true;
			this.shape3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// shape2
			// 
			this.shape2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(7.5590629577636719D), Telerik.Reporting.Drawing.Unit.Pixel(173.97637939453125D));
			this.shape2.Name = "shape2";
			this.shape2.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(241.88980102539063D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape2.Stretch = true;
			this.shape2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// titleTextBox
			// 
			this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.40719735622406006D), Telerik.Reporting.Drawing.Unit.Cm(0.18562497198581696D));
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.1928024291992188D), Telerik.Reporting.Drawing.Unit.Cm(0.88562500476837158D));
			this.titleTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.titleTextBox.Style.Font.Name = "Arial";
			this.titleTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
			this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
			this.titleTextBox.StyleName = "Title";
			this.titleTextBox.Value = "Consignment Note";
			// 
			// consignmentNoDataTextBox
			// 
			this.consignmentNoDataTextBox.CanGrow = true;
			this.consignmentNoDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.6002001762390137D), Telerik.Reporting.Drawing.Unit.Cm(0.18572509288787842D));
			this.consignmentNoDataTextBox.Name = "consignmentNoDataTextBox";
			this.consignmentNoDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.865018367767334D), Telerik.Reporting.Drawing.Unit.Cm(0.88552480936050415D));
			this.consignmentNoDataTextBox.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.consignmentNoDataTextBox.Style.Font.Name = "Arial";
			this.consignmentNoDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
			this.consignmentNoDataTextBox.StyleName = "Data";
			this.consignmentNoDataTextBox.Value = "=Fields.ConsignmentNo";
			// 
			// supplierNameDataTextBox
			// 
			this.supplierNameDataTextBox.CanGrow = true;
			this.supplierNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776D), Telerik.Reporting.Drawing.Unit.Cm(1.3814176321029663D));
			this.supplierNameDataTextBox.Name = "supplierNameDataTextBox";
			this.supplierNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.065218925476074D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierNameDataTextBox.Style.Font.Bold = true;
			this.supplierNameDataTextBox.Style.Font.Name = "Arial";
			this.supplierNameDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierNameDataTextBox.StyleName = "Data";
			this.supplierNameDataTextBox.Value = "=Fields.SupplierName";
			// 
			// supplierAddress1DataTextBox
			// 
			this.supplierAddress1DataTextBox.CanGrow = true;
			this.supplierAddress1DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776D), Telerik.Reporting.Drawing.Unit.Cm(1.885624885559082D));
			this.supplierAddress1DataTextBox.Name = "supplierAddress1DataTextBox";
			this.supplierAddress1DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.065218925476074D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierAddress1DataTextBox.Style.Font.Bold = true;
			this.supplierAddress1DataTextBox.Style.Font.Name = "Arial";
			this.supplierAddress1DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierAddress1DataTextBox.StyleName = "Data";
			this.supplierAddress1DataTextBox.Value = "=Fields.SupplierAddress1";
			// 
			// supplierAddress2DataTextBox
			// 
			this.supplierAddress2DataTextBox.CanGrow = true;
			this.supplierAddress2DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776D), Telerik.Reporting.Drawing.Unit.Cm(2.38983154296875D));
			this.supplierAddress2DataTextBox.Name = "supplierAddress2DataTextBox";
			this.supplierAddress2DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.065218925476074D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierAddress2DataTextBox.Style.Font.Bold = true;
			this.supplierAddress2DataTextBox.Style.Font.Name = "Arial";
			this.supplierAddress2DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierAddress2DataTextBox.StyleName = "Data";
			this.supplierAddress2DataTextBox.Value = "=Fields.SupplierAddress2";
			// 
			// supplierAddress3DataTextBox
			// 
			this.supplierAddress3DataTextBox.CanGrow = true;
			this.supplierAddress3DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776D), Telerik.Reporting.Drawing.Unit.Cm(2.8940401077270508D));
			this.supplierAddress3DataTextBox.Name = "supplierAddress3DataTextBox";
			this.supplierAddress3DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.065218925476074D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierAddress3DataTextBox.Style.Font.Bold = true;
			this.supplierAddress3DataTextBox.Style.Font.Name = "Arial";
			this.supplierAddress3DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierAddress3DataTextBox.StyleName = "Data";
			this.supplierAddress3DataTextBox.Value = "=Fields.SupplierAddress3";
			// 
			// supplierAddress4DataTextBox
			// 
			this.supplierAddress4DataTextBox.CanGrow = true;
			this.supplierAddress4DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776D), Telerik.Reporting.Drawing.Unit.Cm(3.3982470035552979D));
			this.supplierAddress4DataTextBox.Name = "supplierAddress4DataTextBox";
			this.supplierAddress4DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.065218925476074D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierAddress4DataTextBox.Style.Font.Bold = true;
			this.supplierAddress4DataTextBox.Style.Font.Name = "Arial";
			this.supplierAddress4DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierAddress4DataTextBox.StyleName = "Data";
			this.supplierAddress4DataTextBox.Value = "=Fields.SupplierAddress4";
			// 
			// supplierAddress5DataTextBox
			// 
			this.supplierAddress5DataTextBox.CanGrow = true;
			this.supplierAddress5DataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39999979734420776D), Telerik.Reporting.Drawing.Unit.Cm(3.9024538993835449D));
			this.supplierAddress5DataTextBox.Name = "supplierAddress5DataTextBox";
			this.supplierAddress5DataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.065218925476074D), Telerik.Reporting.Drawing.Unit.Cm(0.50420725345611572D));
			this.supplierAddress5DataTextBox.Style.Font.Bold = true;
			this.supplierAddress5DataTextBox.Style.Font.Name = "Arial";
			this.supplierAddress5DataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.supplierAddress5DataTextBox.StyleName = "Data";
			this.supplierAddress5DataTextBox.Value = "=Fields.SupplierAddress5";
			// 
			// raisedByDataTextBox
			// 
			this.raisedByDataTextBox.CanGrow = true;
			this.raisedByDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000019669532776D), Telerik.Reporting.Drawing.Unit.Cm(5.5031247138977051D));
			this.raisedByDataTextBox.Name = "raisedByDataTextBox";
			this.raisedByDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.4000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
			this.raisedByDataTextBox.Style.Font.Name = "Arial";
			this.raisedByDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.raisedByDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.raisedByDataTextBox.StyleName = "Data";
			this.raisedByDataTextBox.Value = "=Fields.RaisedBy";
			// 
			// dateCreatedDataTextBox
			// 
			this.dateCreatedDataTextBox.CanGrow = true;
			this.dateCreatedDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.79000186920166D), Telerik.Reporting.Drawing.Unit.Cm(5.5031251907348633D));
			this.dateCreatedDataTextBox.Name = "dateCreatedDataTextBox";
			this.dateCreatedDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.1298997402191162D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
			this.dateCreatedDataTextBox.Style.Font.Name = "Arial";
			this.dateCreatedDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.dateCreatedDataTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.dateCreatedDataTextBox.StyleName = "Data";
			this.dateCreatedDataTextBox.Value = "=Fields.DateCreated";
			// 
			// MainLogo
			// 
			this.MainLogo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(465.63778686523438D), Telerik.Reporting.Drawing.Unit.Pixel(7.0157470703125D));
			this.MainLogo.Name = "MainLogo";
			this.MainLogo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(136.06304931640625D), Telerik.Reporting.Drawing.Unit.Pixel(90.708663940429688D));
			this.MainLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
			// 
			// textBox7
			// 
			this.textBox7.Angle = 0D;
			this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(7.5590629577636719D), Telerik.Reporting.Drawing.Unit.Pixel(185.30738830566406D));
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(241.8897705078125D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
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
			this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(483.1417236328125D), Telerik.Reporting.Drawing.Unit.Pixel(185.31497192382813D));
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(118.55528259277344D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
			this.textBox8.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox8.Style.Font.Bold = true;
			this.textBox8.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
			this.textBox8.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5D);
			this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox8.Value = "DATE";
			// 
			// shape5
			// 
			this.shape5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(248.80343627929688D), Telerik.Reporting.Drawing.Unit.Pixel(173.97637939453125D));
			this.shape5.Name = "shape5";
			this.shape5.ShapeType = new Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45D, 0);
			this.shape5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(234.33074951171875D), Telerik.Reporting.Drawing.Unit.Pixel(64.251983642578125D));
			this.shape5.Stretch = true;
			this.shape5.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			// 
			// textBox12
			// 
			this.textBox12.Angle = 0D;
			this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(249.44882202148438D), Telerik.Reporting.Drawing.Unit.Pixel(185.31497192382813D));
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(233.68534851074219D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
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
			this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(248.80340576171875D), Telerik.Reporting.Drawing.Unit.Pixel(249.56692504882813D));
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(234.33073425292969D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
			this.textBox13.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox13.Style.Font.Bold = true;
			this.textBox13.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
			this.textBox13.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5D);
			this.textBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox13.Value = "SIGNED";
			// 
			// textBox14
			// 
			this.textBox14.Angle = 0D;
			this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(483.1417236328125D), Telerik.Reporting.Drawing.Unit.Pixel(249.56692504882813D));
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(118.55528259277344D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
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
			this.textBox15.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(7.5590629577636719D), Telerik.Reporting.Drawing.Unit.Pixel(249.56692504882813D));
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(241.8897705078125D), Telerik.Reporting.Drawing.Unit.Pixel(26.456695556640625D));
			this.textBox15.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox15.Style.Font.Bold = true;
			this.textBox15.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(0D);
			this.textBox15.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(5D);
			this.textBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
			this.textBox15.Value = "RECEIVED BY";
			// 
			// textBox11
			// 
			this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(335.5311279296875D), Telerik.Reporting.Drawing.Unit.Pixel(317.59466552734375D));
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(266.169677734375D), Telerik.Reporting.Drawing.Unit.Pixel(22.677154541015625D));
			this.textBox11.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox11.Style.Font.Bold = true;
			this.textBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.textBox11.Value = "INSTRUCTIONS";
			// 
			// textBox10
			// 
			this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(94.488189697265625D), Telerik.Reporting.Drawing.Unit.Pixel(317.59466552734375D));
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(228.07870483398438D), Telerik.Reporting.Drawing.Unit.Pixel(22.677154541015625D));
			this.textBox10.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox10.Style.Font.Bold = true;
			this.textBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.textBox10.Value = "DESCRIPTION";
			// 
			// textBox9
			// 
			this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(7.5590629577636719D), Telerik.Reporting.Drawing.Unit.Pixel(317.59466552734375D));
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(83.14959716796875D), Telerik.Reporting.Drawing.Unit.Pixel(22.677154541015625D));
			this.textBox9.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
			this.textBox9.Style.Font.Bold = true;
			this.textBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
			this.textBox9.Value = "ITEM";
			// 
			// shape4
			// 
			this.shape4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(6.70458984375D), Telerik.Reporting.Drawing.Unit.Pixel(336.49606323242188D));
			this.shape4.Name = "shape4";
			this.shape4.ShapeType = new Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW);
			this.shape4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(594.9962158203125D), Telerik.Reporting.Drawing.Unit.Pixel(11.334793090820313D));
			this.shape4.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			this.shape4.Style.Font.Bold = false;
			this.shape4.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.5D);
			// 
			// reportFooter
			// 
			this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
			this.reportFooter.Name = "reportFooter";
			// 
			// detail
			// 
			this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1825997829437256D);
			this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.jobRefDataTextBox1,
            this.descriptionDataTextBox,
            this.instructionsDataTextBox,
            this.shape9});
			this.detail.Name = "detail";
			// 
			// jobRefDataTextBox1
			// 
			this.jobRefDataTextBox1.CanGrow = true;
			this.jobRefDataTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224D), Telerik.Reporting.Drawing.Unit.Cm(0.18260028958320618D));
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
			this.descriptionDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.5D), Telerik.Reporting.Drawing.Unit.Cm(0.18260028958320618D));
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
			this.instructionsDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.877593994140625D), Telerik.Reporting.Drawing.Unit.Cm(0.18260028958320618D));
			this.instructionsDataTextBox.Name = "instructionsDataTextBox";
			this.instructionsDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.04240608215332D), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791D));
			this.instructionsDataTextBox.Style.Font.Name = "Arial";
			this.instructionsDataTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
			this.instructionsDataTextBox.StyleName = "Data";
			this.instructionsDataTextBox.Value = "=Fields.Instructions";
			// 
			// shape9
			// 
			this.shape9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Pixel(6.70458984375D), Telerik.Reporting.Drawing.Unit.Pixel(29.586151123046875D));
			this.shape9.Name = "shape9";
			this.shape9.ShapeType = new Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW);
			this.shape9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Pixel(594.9962158203125D), Telerik.Reporting.Drawing.Unit.Pixel(11.334793090820313D));
			this.shape9.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			this.shape9.Style.Font.Bold = false;
			this.shape9.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1D);
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
			this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Mm(15.399999618530273D);
			this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Mm(15.399999618530273D);
			this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Mm(15.399999618530273D);
			this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Mm(15.399999618530273D);
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
			this.Width = Telerik.Reporting.Drawing.Unit.Pixel(634.960693359375D);
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion

		private Telerik.Reporting.ObjectDataSource ReportData;
		private Telerik.Reporting.PageHeaderSection pageHeader;
		private Telerik.Reporting.PageFooterSection pageFooter;
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
		public Telerik.Reporting.TextBox dateCreatedDataTextBox;
		private Telerik.Reporting.ReportFooterSection reportFooter;
		private Telerik.Reporting.DetailSection detail;
		private Telerik.Reporting.TextBox jobRefDataTextBox1;
		private Telerik.Reporting.TextBox descriptionDataTextBox;
		private Telerik.Reporting.TextBox instructionsDataTextBox;
		private Telerik.Reporting.TextBox textBox1;
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
		private Telerik.Reporting.Shape shape9;
		private Telerik.Reporting.TextBox CompanyAddressTextBox;
		private Telerik.Reporting.TextBox textBox2;

	}
}