// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  DESKTOP-VAJP4OB
// DateTime: 12/01/2018 09:49:54
// UserName: Martin
// Input file <StepP21Parser.y - 04/10/2016 09:01:57>

// options: lines gplex

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace Xbim.IO.Parser
{
public enum Tokens {error=63,EOF=64,ISOSTEPSTART=65,HEADER=66,
    ENDSEC=67,DATA=68,ISOSTEPEND=69,SCOPE=70,ENDSCOPE=71,ENTITY=72,
    TYPE=73,INTEGER=74,FLOAT=75,STRING=76,BOOLEAN=77,IDENTITY=78,
    TEXT=79,NONDEF=80,OVERRIDE=81,ENUM=82,HEXA=83,ILLEGALCHAR=84,
    MISC=85};

public partial struct ValueType
#line 10 "StepP21Parser.y"
      {
		public string strVal;
	  }
#line default
// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
public partial class P21Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from StepP21Parser.y - 04/10/2016 09:01:57
#line 2 "StepP21Parser.y"
 public bool InHeader = false;
#line default
  // End verbatim content from StepP21Parser.y - 04/10/2016 09:01:57

#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[62];
  private static State[] states = new State[97];
  private static string[] nonTerms = new string[] {
      "stepFile", "trailingSpace", "$accept", "endStep", "beginStep", "startHeader", 
      "stepFile1", "headerEntities", "endSec", "endOfHeader", "model", "stepFile2", 
      "stepFile3", "headerEntity", "entityType", "listArgument", "argument", 
      "listType", "beginList", "endList", "argumentList", "bloc", "entityLabel", 
      "entity", "beginScope", "endScope", "complex", "uniqueID", "export", "beginExport", 
      };

  static P21Parser() {
    states[0] = new State(new int[]{65,93,72,72,63,73},new int[]{-1,1,-7,3,-5,4,-12,94,-13,95,-11,96,-22,77,-23,19});
    states[1] = new State(new int[]{64,2});
    states[2] = new State(-1);
    states[3] = new State(-11);
    states[4] = new State(new int[]{66,92},new int[]{-6,5});
    states[5] = new State(new int[]{73,54,84,55,63,84,67,17},new int[]{-8,6,-9,85,-14,91,-15,81});
    states[6] = new State(new int[]{67,17,73,54,84,55,63,84},new int[]{-9,7,-14,80,-15,81});
    states[7] = new State(new int[]{68,79},new int[]{-10,8});
    states[8] = new State(new int[]{72,72,63,73},new int[]{-11,9,-22,77,-23,19});
    states[9] = new State(new int[]{67,17,72,72,63,73},new int[]{-9,10,-22,16,-23,19});
    states[10] = new State(new int[]{69,12},new int[]{-4,11});
    states[11] = new State(-8);
    states[12] = new State(new int[]{32,15,64,-4},new int[]{-2,13});
    states[13] = new State(new int[]{32,14,64,-5});
    states[14] = new State(-3);
    states[15] = new State(-2);
    states[16] = new State(-43);
    states[17] = new State(new int[]{32,15,68,-15,69,-15},new int[]{-2,18});
    states[18] = new State(new int[]{32,14,68,-16,69,-16});
    states[19] = new State(new int[]{61,20});
    states[20] = new State(new int[]{73,54,84,55,40,56,70,78},new int[]{-24,21,-25,23,-15,28});
    states[21] = new State(new int[]{59,22});
    states[22] = new State(-44);
    states[23] = new State(new int[]{72,72,63,73,71,63},new int[]{-11,24,-26,74,-22,77,-23,19});
    states[24] = new State(new int[]{71,63,72,72,63,73},new int[]{-26,25,-22,16,-23,19});
    states[25] = new State(new int[]{73,54,84,55,40,56},new int[]{-24,26,-15,28});
    states[26] = new State(new int[]{59,27});
    states[27] = new State(-45);
    states[28] = new State(new int[]{40,46},new int[]{-16,29,-19,30});
    states[29] = new State(-50);
    states[30] = new State(new int[]{63,52,41,51,78,36,74,37,75,38,76,39,77,40,82,41,83,42,80,43,81,44,40,46,73,49},new int[]{-20,31,-21,32,-17,53,-16,45,-19,30,-18,47});
    states[31] = new State(-36);
    states[32] = new State(new int[]{44,34,63,50,41,51},new int[]{-20,33});
    states[33] = new State(-37);
    states[34] = new State(new int[]{78,36,74,37,75,38,76,39,77,40,82,41,83,42,80,43,81,44,40,46,73,49},new int[]{-17,35,-16,45,-19,30,-18,47});
    states[35] = new State(-40);
    states[36] = new State(-22);
    states[37] = new State(-23);
    states[38] = new State(-24);
    states[39] = new State(-25);
    states[40] = new State(-26);
    states[41] = new State(-27);
    states[42] = new State(-28);
    states[43] = new State(-29);
    states[44] = new State(-30);
    states[45] = new State(-31);
    states[46] = new State(-34);
    states[47] = new State(new int[]{40,46},new int[]{-16,48,-19,30});
    states[48] = new State(-32);
    states[49] = new State(-33);
    states[50] = new State(-41);
    states[51] = new State(-35);
    states[52] = new State(-38);
    states[53] = new State(-39);
    states[54] = new State(-60);
    states[55] = new State(-61);
    states[56] = new State(new int[]{73,54,84,55},new int[]{-27,57,-15,61});
    states[57] = new State(new int[]{41,58,73,54,84,55},new int[]{-15,59});
    states[58] = new State(-51);
    states[59] = new State(new int[]{40,46},new int[]{-16,60,-19,30});
    states[60] = new State(-49);
    states[61] = new State(new int[]{40,46},new int[]{-16,62,-19,30});
    states[62] = new State(-48);
    states[63] = new State(new int[]{47,71,73,-57,84,-57,40,-57},new int[]{-30,64});
    states[64] = new State(new int[]{78,69},new int[]{-29,65,-28,70});
    states[65] = new State(new int[]{47,66,44,67});
    states[66] = new State(-58);
    states[67] = new State(new int[]{78,69},new int[]{-28,68});
    states[68] = new State(-55);
    states[69] = new State(-53);
    states[70] = new State(-54);
    states[71] = new State(-56);
    states[72] = new State(-59);
    states[73] = new State(-47);
    states[74] = new State(new int[]{73,54,84,55,40,56},new int[]{-24,75,-15,28});
    states[75] = new State(new int[]{59,76});
    states[76] = new State(-46);
    states[77] = new State(-42);
    states[78] = new State(-52);
    states[79] = new State(-21);
    states[80] = new State(-18);
    states[81] = new State(new int[]{40,46},new int[]{-16,82,-19,30});
    states[82] = new State(new int[]{59,83});
    states[83] = new State(-19);
    states[84] = new State(-20);
    states[85] = new State(new int[]{68,79},new int[]{-10,86});
    states[86] = new State(new int[]{72,72,63,73},new int[]{-11,87,-22,77,-23,19});
    states[87] = new State(new int[]{63,90,67,17,72,72},new int[]{-9,88,-22,16,-23,19});
    states[88] = new State(new int[]{69,12},new int[]{-4,89});
    states[89] = new State(-9);
    states[90] = new State(new int[]{64,-10,63,-47,67,-47,72,-47});
    states[91] = new State(-17);
    states[92] = new State(-7);
    states[93] = new State(-6);
    states[94] = new State(-12);
    states[95] = new State(-13);
    states[96] = new State(new int[]{72,72,63,73,64,-14},new int[]{-22,16,-23,19});

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-3, new int[]{-1,64});
    rules[2] = new Rule(-2, new int[]{32});
    rules[3] = new Rule(-2, new int[]{-2,32});
    rules[4] = new Rule(-4, new int[]{69});
    rules[5] = new Rule(-4, new int[]{69,-2});
    rules[6] = new Rule(-5, new int[]{65});
    rules[7] = new Rule(-6, new int[]{66});
    rules[8] = new Rule(-7, new int[]{-5,-6,-8,-9,-10,-11,-9,-4});
    rules[9] = new Rule(-12, new int[]{-5,-6,-9,-10,-11,-9,-4});
    rules[10] = new Rule(-13, new int[]{-5,-6,-9,-10,-11,63});
    rules[11] = new Rule(-1, new int[]{-7});
    rules[12] = new Rule(-1, new int[]{-12});
    rules[13] = new Rule(-1, new int[]{-13});
    rules[14] = new Rule(-1, new int[]{-11});
    rules[15] = new Rule(-9, new int[]{67});
    rules[16] = new Rule(-9, new int[]{67,-2});
    rules[17] = new Rule(-8, new int[]{-14});
    rules[18] = new Rule(-8, new int[]{-8,-14});
    rules[19] = new Rule(-14, new int[]{-15,-16,59});
    rules[20] = new Rule(-14, new int[]{63});
    rules[21] = new Rule(-10, new int[]{68});
    rules[22] = new Rule(-17, new int[]{78});
    rules[23] = new Rule(-17, new int[]{74});
    rules[24] = new Rule(-17, new int[]{75});
    rules[25] = new Rule(-17, new int[]{76});
    rules[26] = new Rule(-17, new int[]{77});
    rules[27] = new Rule(-17, new int[]{82});
    rules[28] = new Rule(-17, new int[]{83});
    rules[29] = new Rule(-17, new int[]{80});
    rules[30] = new Rule(-17, new int[]{81});
    rules[31] = new Rule(-17, new int[]{-16});
    rules[32] = new Rule(-17, new int[]{-18,-16});
    rules[33] = new Rule(-18, new int[]{73});
    rules[34] = new Rule(-19, new int[]{40});
    rules[35] = new Rule(-20, new int[]{41});
    rules[36] = new Rule(-16, new int[]{-19,-20});
    rules[37] = new Rule(-16, new int[]{-19,-21,-20});
    rules[38] = new Rule(-16, new int[]{-19,63});
    rules[39] = new Rule(-21, new int[]{-17});
    rules[40] = new Rule(-21, new int[]{-21,44,-17});
    rules[41] = new Rule(-21, new int[]{-21,63});
    rules[42] = new Rule(-11, new int[]{-22});
    rules[43] = new Rule(-11, new int[]{-11,-22});
    rules[44] = new Rule(-22, new int[]{-23,61,-24,59});
    rules[45] = new Rule(-22, new int[]{-23,61,-25,-11,-26,-24,59});
    rules[46] = new Rule(-22, new int[]{-23,61,-25,-26,-24,59});
    rules[47] = new Rule(-22, new int[]{63});
    rules[48] = new Rule(-27, new int[]{-15,-16});
    rules[49] = new Rule(-27, new int[]{-27,-15,-16});
    rules[50] = new Rule(-24, new int[]{-15,-16});
    rules[51] = new Rule(-24, new int[]{40,-27,41});
    rules[52] = new Rule(-25, new int[]{70});
    rules[53] = new Rule(-28, new int[]{78});
    rules[54] = new Rule(-29, new int[]{-28});
    rules[55] = new Rule(-29, new int[]{-29,44,-28});
    rules[56] = new Rule(-30, new int[]{47});
    rules[57] = new Rule(-26, new int[]{71});
    rules[58] = new Rule(-26, new int[]{71,-30,-29,47});
    rules[59] = new Rule(-23, new int[]{72});
    rules[60] = new Rule(-15, new int[]{73});
    rules[61] = new Rule(-15, new int[]{84});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 4: // endStep -> ISOSTEPEND
#line 38 "StepP21Parser.y"
                    {EndParse();}
#line default
        break;
      case 5: // endStep -> ISOSTEPEND, trailingSpace
#line 40 "StepP21Parser.y"
 {EndParse();}
#line default
        break;
      case 6: // beginStep -> ISOSTEPSTART
#line 43 "StepP21Parser.y"
    {BeginParse(); }
#line default
        break;
      case 7: // startHeader -> HEADER
#line 48 "StepP21Parser.y"
    {InHeader=true; BeginHeader();}
#line default
        break;
      case 14: // stepFile -> model
#line 59 "StepP21Parser.y"
         { EndParse(); }
#line default
        break;
      case 15: // endSec -> ENDSEC
#line 62 "StepP21Parser.y"
               {EndSec();}
#line default
        break;
      case 16: // endSec -> ENDSEC, trailingSpace
#line 63 "StepP21Parser.y"
                        {EndSec();}
#line default
        break;
      case 19: // headerEntity -> entityType, listArgument, ';'
#line 69 "StepP21Parser.y"
                                           {EndHeaderEntity();}
#line default
        break;
      case 21: // endOfHeader -> DATA
#line 73 "StepP21Parser.y"
 {  InHeader=false; EndHeader();  }
#line default
        break;
      case 22: // argument -> IDENTITY
#line 76 "StepP21Parser.y"
                            {SetObjectValue(CurrentSemanticValue.strVal);}
#line default
        break;
      case 23: // argument -> INTEGER
#line 77 "StepP21Parser.y"
                        {SetIntegerValue(CurrentSemanticValue.strVal);}
#line default
        break;
      case 24: // argument -> FLOAT
#line 78 "StepP21Parser.y"
                          {SetFloatValue(CurrentSemanticValue.strVal);}
#line default
        break;
      case 25: // argument -> STRING
#line 79 "StepP21Parser.y"
                       {SetStringValue(CurrentSemanticValue.strVal);}
#line default
        break;
      case 26: // argument -> BOOLEAN
#line 80 "StepP21Parser.y"
                        {SetBooleanValue(CurrentSemanticValue.strVal);}
#line default
        break;
      case 27: // argument -> ENUM
#line 81 "StepP21Parser.y"
                         {SetEnumValue(CurrentSemanticValue.strVal);}
#line default
        break;
      case 28: // argument -> HEXA
#line 82 "StepP21Parser.y"
                         {SetHexValue(CurrentSemanticValue.strVal);}
#line default
        break;
      case 29: // argument -> NONDEF
#line 83 "StepP21Parser.y"
                       {SetNonDefinedValue();}
#line default
        break;
      case 30: // argument -> OVERRIDE
#line 84 "StepP21Parser.y"
                         {SetOverrideValue();}
#line default
        break;
      case 32: // argument -> listType, listArgument
#line 86 "StepP21Parser.y"
                          {EndNestedType(CurrentSemanticValue.strVal);}
#line default
        break;
      case 33: // listType -> TYPE
#line 90 "StepP21Parser.y"
 {  BeginNestedType(CurrentSemanticValue.strVal);  }
#line default
        break;
      case 34: // beginList -> '('
#line 93 "StepP21Parser.y"
 {  BeginList(); }
#line default
        break;
      case 35: // endList -> ')'
#line 96 "StepP21Parser.y"
 { EndList(); }
#line default
        break;
      case 41: // argumentList -> argumentList, error
#line 104 "StepP21Parser.y"
                      {SetErrorMessage();}
#line default
        break;
      case 44: // bloc -> entityLabel, '=', entity, ';'
#line 109 "StepP21Parser.y"
                                  {EndEntity();}
#line default
        break;
      case 45: // bloc -> entityLabel, '=', beginScope, model, endScope, entity, ';'
#line 110 "StepP21Parser.y"
                                                       {EndEntity();}
#line default
        break;
      case 46: // bloc -> entityLabel, '=', beginScope, endScope, entity, ';'
#line 111 "StepP21Parser.y"
                                                 {EndEntity();}
#line default
        break;
      case 47: // bloc -> error
#line 112 "StepP21Parser.y"
          {SetErrorMessage();EndEntity();}
#line default
        break;
      case 53: // uniqueID -> IDENTITY
#line 124 "StepP21Parser.y"
 {   SetObjectValue(CurrentSemanticValue.strVal);  }
#line default
        break;
      case 56: // beginExport -> '/'
#line 130 "StepP21Parser.y"
 {  BeginList();  }
#line default
        break;
      case 59: // entityLabel -> ENTITY
#line 139 "StepP21Parser.y"
 {  NewEntity(CurrentSemanticValue.strVal);  }
#line default
        break;
      case 60: // entityType -> TYPE
#line 142 "StepP21Parser.y"
 {  SetType(CurrentSemanticValue.strVal);  }
#line default
        break;
      case 61: // entityType -> ILLEGALCHAR
#line 145 "StepP21Parser.y"
 {  CharacterError();  }
#line default
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 149 "StepP21Parser.y"


#line default
}
}
