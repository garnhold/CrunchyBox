grammar Tyon;

tyonType
    : ID /*info: get_override*/ # tyonType_Normal /*info: base_type=>TyonType_Direct*/
    | ID /*info: get_override*/ '<' /*group:{*/ tyonType (',' tyonType)* /*group:}*/ '>' # tyonType_Templated /*info: base_type=>TyonType_Direct*/

    | tyonType '[' ']' # tyonType_Array
    ;

tyonObject : tyonType ('(' '&' tyonAddress ')')? ('{' tyonVariable* '}')?;
tyonSurrogate : '$' tyonType ':' tyonAddress;

tyonArray : tyonType '[' (/*group:{*/ tyonValue (',' tyonValue)* /*group:}*/)? ']';

tyonValue
    : NUMBER # tyonValue_Number
    | STRING /*info: custom_load_context*/ # tyonValue_String

    | 'null' # tyonValue_Null
    | '&' tyonAddress # tyonValue_InternalAddress
    | '@' tyonAddress # tyonValue_ExternalAddress

    | tyonObject # tyonValue_Object
    | tyonSurrogate # tyonValue_Surrogate

    | tyonArray # tyonValue_Array
    ;

tyonAddress
    : ID # tyonAddress_Identifier

    | NUMBER /*info: type=>int*/ # tyonAddress_Int
    | STRING /*info: custom_load_context*/ # tyonAddress_String

    | tyonObject # tyonAddress_Object
    ;

tyonVariable : ID '=' tyonValue ';';

NUMBER : ('-'|'+')? [0-9]+ ('.' [0-9]*)?;
STRING : '"' ('\\"'|.)*? '"';
ID : [A-Za-z_][A-Za-z0-9_\.]*;

WHITESPACE : [ \r\n\t]+ -> skip;
