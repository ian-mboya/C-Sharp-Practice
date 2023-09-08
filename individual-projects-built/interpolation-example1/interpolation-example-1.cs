///////String Interpolation //

//String Interpolation combines multiple values into a single literal string by using a "template" and one or more interpolation expressions.
//An interpolation expression is a variable surrounded by an opening and closing curly brace symbol {}. The literal string becomes a template when ot's prefixed by the '$' charaqcter.


//In the example below we have initiliazed two variables i.e version and updateText.
//We call the two string variables to print on console by prefixing with the $ symbol, nesting the variables in a double quatation mark. Within the quatation mark we call each variable by placing them in curly braces {updateText} {Version}


int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");