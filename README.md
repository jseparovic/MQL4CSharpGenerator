# MQL4CSharpGenerator

This project is used in conjunction with MQL4CSharp to populate the MQL commands part of the application

Generated code is placed in the out directory.

First, *scrapeDocs.py* iterates over the MQL docs to create a JSON file of the functions included in "functionlist.txt". I've created a file called "fucntionlist-removed.txt" which is where I've put functions not currently support for various reasons (ie, I've removed stuff you may as well do in C#, and also a few others that were not passing the parse and not a high priority).

Once *scapeDocs.py* runs, it creates function.dump.json. 

Then using jinja2 templates, I run the *generate.py* on the json to produce the code.

The following files are created:

##### MQL.cs
this is where the Metatrader functions are called from. In the MQL4CSharp project there is a Strategy type which extends MQL. You can also just extend MQL directly if you don't want to use the Strategy framework.

##### MQLCommand.cs
enum list of MQL Commands supported

##### mc_funcs.mqh
this converts the MQL command IDs into MQL command calls

##### mc_helpers.mqh
the enum conversion functions

##### mc_returns.mqh
this is a helper to decided which return function to call for a command based on the return type


You probably don't need to rerun this, just grab the mqh files and load them in your metatrader includes directory. I've already copied the C# code to the MQL4CSharp project.

At some stage I will probably tidy this all up..
