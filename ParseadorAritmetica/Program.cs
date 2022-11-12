using Antlr4.Runtime;
using ParseadorAritmetica;

string input = "5*6+9*3-1";
Console.WriteLine($"input: {input}\n");
ICharStream stream = CharStreams.fromString(input);
aritmeticaLexer lexer = new aritmeticaLexer(stream);
CommonTokenStream token = new CommonTokenStream(lexer);
aritmeticaParser parser = new aritmeticaParser(token);
aritmeticaParser.AritmeticaContext tree =parser.aritmetica();
Aritmetica aritmetica = new Aritmetica();
int result = aritmetica.Visit(tree);