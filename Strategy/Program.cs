using Strategy;

var fileReader = new FileReader(new HandleCsv());
fileReader.Read();

var fileReader2 = new FileReader(new HandleExcel());
fileReader2.Read();