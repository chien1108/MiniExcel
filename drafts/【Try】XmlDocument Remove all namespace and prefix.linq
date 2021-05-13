<Query Kind="Program">
  <NuGetReference>Dapper</NuGetReference>
  <NuGetReference>MiniExcel</NuGetReference>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <NuGetReference>System.Data.SqlClient</NuGetReference>
  <Namespace>Dapper</Namespace>
  <Namespace>MiniExcelLibs</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
  <RemoveNamespace>System.Data</RemoveNamespace>
  <RemoveNamespace>System.Diagnostics</RemoveNamespace>
  <RemoveNamespace>System.Linq.Expressions</RemoveNamespace>
  <RemoveNamespace>System.Text</RemoveNamespace>
  <RemoveNamespace>System.Text.RegularExpressions</RemoveNamespace>
  <RemoveNamespace>System.Threading</RemoveNamespace>
  <RemoveNamespace>System.Transactions</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

void Main()
{
	var xml = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<worksheet xmlns=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"" xmlns:r=""http://schemas.openxmlformats.org/officeDocument/2006/relationships"" xmlns:mc=""http://schemas.openxmlformats.org/markup-compatibility/2006"" mc:Ignorable=""x14ac xr xr2 xr3"" xmlns:x14ac=""http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac"" xmlns:xr=""http://schemas.microsoft.com/office/spreadsheetml/2014/revision"" xmlns:xr2=""http://schemas.microsoft.com/office/spreadsheetml/2015/revision2"" xmlns:xr3=""http://schemas.microsoft.com/office/spreadsheetml/2016/revision3"" xr:uid=""{00000000-0001-0000-0000-000000000000}""><dimension ref=""A1:C5""/><sheetViews><sheetView tabSelected=""1"" zoomScaleNormal=""100"" workbookViewId=""0""><selection activeCell=""B6"" sqref=""B6""/></sheetView></sheetViews><sheetFormatPr defaultColWidth=""11.5546875"" defaultRowHeight=""13.2"" x14ac:dyDescent=""0.25""/><cols><col min=""2"" max=""2"" width=""17.109375"" customWidth=""1""/><col min=""3"" max=""3"" width=""21.77734375"" customWidth=""1""/></cols><sheetData><row r=""1"" spans=""1:3"" x14ac:dyDescent=""0.25""><c r=""A1"" s=""4"" t=""s""><v>0</v></c><c r=""B1"" s=""4""/><c r=""C1"" s=""5""/></row><row r=""2"" spans=""1:3"" x14ac:dyDescent=""0.25""><c r=""A2"" s=""2"" t=""s""><v>1</v></c><c r=""B2"" s=""2"" t=""s""><v>8</v></c><c r=""C2"" s=""2"" t=""s""><v>7</v></c></row><row r=""3"" spans=""1:3"" x14ac:dyDescent=""0.25""><c r=""A3"" s=""1""/><c r=""B3"" s=""3"" t=""s""><v>3</v></c><c r=""C3"" s=""3"" t=""s""><v>4</v></c></row><row r=""4"" spans=""1:3"" x14ac:dyDescent=""0.25""><c r=""A4"" s=""2"" t=""s""><v>2</v></c><c r=""B4"" s=""2"" t=""s""><v>8</v></c><c r=""C4"" s=""2"" t=""s""><v>7</v></c></row><row r=""5"" spans=""1:3"" x14ac:dyDescent=""0.25""><c r=""A5"" s=""1""/><c r=""B5"" s=""3"" t=""s""><v>6</v></c><c r=""C5"" s=""3"" t=""s""><v>5</v></c></row></sheetData><mergeCells count=""1""><mergeCell ref=""A1:C1""/></mergeCells><pageMargins left=""0.78749999999999998"" right=""0.78749999999999998"" top=""1.05277777777778"" bottom=""1.05277777777778"" header=""0.78749999999999998"" footer=""0.78749999999999998""/><pageSetup orientation=""portrait"" useFirstPageNumber=""1"" horizontalDpi=""300"" verticalDpi=""300"" r:id=""rId1""/><headerFooter><oddHeader>&amp;C&amp;""Times New Roman,Regular""&amp;12&amp;A</oddHeader><oddFooter>&amp;C&amp;""Times New Roman,Regular""&amp;12Page &amp;P</oddFooter></headerFooter></worksheet>";
	var doc = new XmlDocument();
	doc.LoadXml(xml);
	SetPrefix("x",doc.ChildNodes[1]);
	Console.WriteLine(doc);
}

// You can define other methods, fields, classes and namespaces here
private static void SetPrefix(string prefix, XmlNode node)
{
	node.Prefix = prefix;
	
	foreach (XmlNode n in node.ChildNodes)
	{
		SetPrefix(prefix, n);
	}
}