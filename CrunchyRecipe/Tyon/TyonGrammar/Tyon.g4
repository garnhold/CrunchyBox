grammar Tyon;

tyonType
    : ID /*info: get_override*/ # tyonType_Normal /*info: base_type=>TyonType_Direct*/
    | ID /*info: get_override*/ '<' /*group:{*/ tyonType (',' tyonType)* /*group:}*/ '>' # tyonType_Templated /*info: base_type=>TyonType_Direct*/

    | tyonType '[' ']' # tyonType_Array
    ;

tyonObject : tyonType ('(' '&' tyonAddress ')')? ('{' tyonVariable* '}')?;
tyonSurrogate : '$' tyonType ':' STRING /*info: custom_load_context*/;

tyonArray : tyonType '[' (/*group:{*/ tyonValue (',' tyonValue)* /*group:}*/)? ']';

tyonValue
    : INT # tyonValue_Int
    | FLOAT # tyonValue_Float
    | STRING /*info: custom_load_context*/ # tyonValue_String

    | 'null' # tyonValue_Null
    | 'typeof' '(' tyonType ')' # tyonValue_Type

    | '&' tyonAddress # tyonValue_InternalAddress
    | '@' tyonAddress # tyonValue_ExternalAddress

    | tyonObject # tyonValue_Object
    | tyonSurrogate # tyonValue_Surrogate

    | tyonArray # tyonValue_Array
    ;

tyonAddress
    : ID # tyonAddress_Identifier

    | INT # tyonAddress_Int
    | STRING /*info: custom_load_context*/ # tyonAddress_String
    ;

tyonVariable : ID '=' tyonValue ';';


INT /*info: type=>long*/ : ('-'|'+')? [0-9]+;
FLOAT /*info: type=>decimal*/ : ('-'|'+')? [0-9]+ '.' [0-9]*?;
STRING : '"' ('\\"'|.)*? '"';
ID : [A-Za-z_][A-Za-z0-9_\.]*;

WHITESPACE : [ \r\n\t]+ -> skip;
