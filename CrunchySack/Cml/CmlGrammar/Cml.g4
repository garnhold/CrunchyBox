grammar Cml;

cmlClassDefinition : cmlEntity /*info: name=>entity*/;
cmlFragmentDefinition : cmlEntity /*info: name=>entity*/;

cmlValueSource
    : cmlComponentSource /*info: name=>component_source*/ # cmlValueSource_ComponentSource
    | cmlComponentSourceList /*info: name=>component_source_list*/ # cmlValueSource_ComponentSourceList

    | cmlLinkSource /*info: name=>link_source*/ # cmlValueSource_LinkSource
    | cmlLinkSourceWithEntitySource /*info: name=>link_source_with_entity_source*/ # cmlValueSource_LinkSourceWithEntitySource

    | cmlFunctionSource /*info: name=>function_source*/ # cmlValueSource_FunctionSource
    ;

cmlComponentSource
    : cmlPrimitive /*info: name=>primitive*/ # cmlComponentSource_Primitive

    | cmlEntity /*info: name=>entity*/ # cmlComponentSource_Entity
    | cmlConstructor /*info: name=>constructor*/ # cmlComponentSource_Constructor

    | cmlInsertParameter /*info: name=>insert_parameter*/ # cmlComponentSource_InsertParameter
    ;

cmlComponentSourceList : '{' cmlComponentSource* /*info: name=>component_sources*/ '}';

cmlPrimitive
    : INT # cmlPrimitive_Int
    | FLOAT # cmlPrimitive_Float
    | DOUBLE # cmlPrimitive_Double

    | NULL # cmlPrimitive_Null
    | BOOL # cmlPrimitive_Bool
    | STRING /*info: custom_load_context*/ # cmlPrimitive_String
    ;

cmlEntity : ID /*info: name=>tag*/ (ID /*info: name=>id*/)?
    ('(' cmlEntityAttribute* /*info: name=>attributes*/ ')')?
    (cmlEntityChildren /*info: name=>children*/ | cmlEntityMountPoint /*info: name=>mount_point*/)?
    ;

cmlEntityMountPoint : '[' '*' ']';

cmlEntityChildren
    : cmlComponentSourceList /*info: name=>component_source_list*/ # cmlEntityChildren_Static
    | cmlLinkSource /*info: name=>link_source*/ # cmlEntityChildren_Dynamic
    | cmlLinkSourceWithEntitySource /*info: name=>link_source_with_entity_source*/ # cmlEntityChildren_DynamicInline
    ;

cmlEntityAttribute : ID /*info: name=>name*/ '=' cmlValueSource /*info: name=>value_source*/;

cmlConstructor : ID /*info: name=>name*/ '(' cmlValueSourceList /*info: name=>argument_sources*/ ')';
cmlValueSourceList : /*group:{*/ (cmlValueSource (',' cmlValueSource)*)? /*group:}*/ /*info: name=>value_sources*/;

cmlLinkSource
    : '[' cmlScriptEntry_Link /*info: name=>link*/ ']' cmlInfo? /*info: name=>info*/ # cmlLinkSource_Normal
    | '[' cmlInsertParameter /*info: name=>insert_parameter*/ ']' # cmlLinkSource_InsertParameter
    ;

cmlLinkSourceWithEntitySource : cmlLinkSource /*info: name=>link_source*/ '{' cmlEntity? /*info: name=>entity*/ '}';

cmlFunctionSource
    : '<' cmlScriptEntry_Function /*info: name=>function*/ '>' cmlInfo? /*info: name=>info*/ # cmlFunctionSource_Normal
    | '<' cmlInsertParameter /*info: name=>insert_parameter*/ '>' # cmlFunctionSource_InsertParameter
    ;

cmlInsertParameter : '^' ID ('?' cmlValueSource /*info: name=>default_value_source*/)?;

cmlInfo : '(' cmlInfoSetting* /*info: name=>settings*/ ')';
cmlInfoSetting /*info: multiple_type=>labeled_item_set, label_type=>string*/
    : ID /*info: name=>name*/ '=' STRING /*info: name=>value, custom_load_context*/;





cmlScriptEntry_Link /*info: base_type=>CmlScriptEntry, store_text*/ : cmlScriptExpression /*info: name=>expression*/;
cmlScriptEntry_Function /*info: base_type=>CmlScriptEntry, store_text*/ : ('(' cmlScriptFunctionParameters /*info: name=>function_parameters*/ ')')? cmlScriptLambda /*info: name=>lambda*/;

cmlScriptFunctionParameter : ID /*info: name=>type_name*/ ID /*info: name=>name*/;
cmlScriptFunctionParameters : /*group:{*/ (cmlScriptFunctionParameter (',' cmlScriptFunctionParameter)*)? /*group:}*/ /*info: name=>function_parameters*/;

cmlScriptExpression
    : cmlScriptSubExpression /*info: name=>sub_expression*/ # cmlScriptExpression_Direct
    | cmlScriptExpression /*info: name=>indirection_expression*/ '.' cmlScriptSubExpression /*info: name=>sub_expression*/ # cmlScriptExpression_Indirect

    | '(' cmlScriptExpression /*info: name=>inner_expression*/ ')' # cmlScriptExpression_Parenthetical

    | cmlScriptExpression /*info: name=>left, get_override*/ cmlScriptBinaryOperatorMultiplicative /*info: name=>operator_multiplicative*/ cmlScriptExpression /*info: name=>right, get_override*/  # cmlScriptExpression_BinaryOperation_Multiplicative /*info: base_type=>CmlScriptExpression_BinaryOperation*/
    | cmlScriptExpression /*info: name=>left, get_override*/ cmlScriptBinaryOperatorAdditive /*info: name=>operator_additive*/ cmlScriptExpression /*info: name=>right, get_override*/ # cmlScriptExpression_BinaryOperation_Additive /*info: base_type=>CmlScriptExpression_BinaryOperation*/
    | cmlScriptExpression /*info: name=>left, get_override*/ cmlScriptBinaryOperatorComparative /*info: name=>operator_comparative*/ cmlScriptExpression /*info: name=>right, get_override*/ # cmlScriptExpression_BinaryOperation_Comparative /*info: base_type=>CmlScriptExpression_BinaryOperation*/
    | cmlScriptExpression /*info: name=>left, get_override*/ cmlScriptBinaryOperatorBoolean /*info: name=>operator_boolean*/ cmlScriptExpression /*info: name=>right, get_override*/ # cmlScriptExpression_BinaryOperation_Boolean /*info: base_type=>CmlScriptExpression_BinaryOperation*/
    ;

cmlScriptBinaryOperatorMultiplicative /*info: base_type=>CmlScriptBinaryOperator*/
    : '*' # cmlScriptBinaryOperatorMultiplicative_Times
    | '/' # cmlScriptBinaryOperatorMultiplicative_Divide
    | '%' # cmlScriptBinaryOperatorMultiplicative_Modulo
    ;

cmlScriptBinaryOperatorAdditive /*info: base_type=>CmlScriptBinaryOperator*/
    : '+' # cmlScriptBinaryOperatorAdditive_Plus
    | '-' # cmlScriptBinaryOperatorAdditive_Minus
    ;

cmlScriptBinaryOperatorComparative /*info: base_type=>CmlScriptBinaryOperator*/
    : '=' '=' # cmlScriptBinaryOperatorComparative_IsEqualTo
    | '!' '=' # cmlScriptBinaryOperatorComparative_IsNotEqualTo

    | '<' # cmlScriptBinaryOperatorComparative_IsLessThan
    | '<' '=' # cmlScriptBinaryOperatorComparative_IsLessThanOrEqualTo

    | '>' # cmlScriptBinaryOperatorComparative_IsGreaterThan
    | '>' '=' # cmlScriptBinaryOperatorComparative_IsGreaterThanOrEqualTo
    ;

cmlScriptBinaryOperatorBoolean /*info: base_type=>CmlScriptBinaryOperator*/
    : '|' # cmlScriptBinaryOperatorBoolean_Or
    | '&' # cmlScriptBinaryOperatorBoolean_And
    ;

cmlScriptSubExpression
    : INT # cmlScriptSubExpression_Constant_Int /*info: base_type=>CmlScriptSubExpression_Constant*/
    | FLOAT # cmlScriptSubExpression_Constant_Float /*info: base_type=>CmlScriptSubExpression_Constant*/
    | DOUBLE # cmlScriptSubExpression_Constant_Double /*info: base_type=>CmlScriptSubExpression_Constant*/

    | NULL # cmlScriptSubExpression_Constant_Null /*info: base_type=>CmlScriptSubExpression_Constant*/
    | BOOL # cmlScriptSubExpression_Constant_Bool /*info: base_type=>CmlScriptSubExpression_Constant*/
    | STRING /*info: custom_load_context*/ # cmlScriptSubExpression_Constant_String /*info: base_type=>CmlScriptSubExpression_Constant*/

    | cmlScriptSyntheticString /*info: name=>synthetic_string*/ # cmlScriptSubExpression_SyntheticString

    | cmlInsertParameter /*info: name=>insert_parameter*/ # cmlScriptSubExpression_InsertParameter

    | cmlScriptValueReference /*info: name=>value_reference*/ # cmlScriptSubExpression_ValueReference
    | cmlScriptInsertRepresentation /*info: name=>insert_representation*/ # cmlScriptSubExpression_InsertRepresentation

    | cmlScriptFunctionCall /*info: name=>function_call*/ # cmlScriptSubExpression_FunctionCall
    ;

cmlScriptSyntheticString : '$' STRING /*info: custom_load_context*/;

cmlScriptInsertRepresentation
    : '@' ID # cmlScriptInsertRepresentation_Normal
    | '@' 'this' # cmlScriptInsertRepresentation_This
    ;

cmlScriptValueReference
    : ID # cmlScriptValueReference_Normal
    | 'this' # cmlScriptValueReference_This
    | 'parent' # cmlScriptValueReference_Parent
    | 'parent' '<' ID /*info: name=>type_name*/ '>' # cmlScriptValueReference_ParentOfType
    ;

cmlScriptFunctionCall : ID '(' cmlScriptExpressionList /*info: name=>arguments*/ ')';
cmlScriptExpressionList : /*group:{*/ (cmlScriptExpression (',' cmlScriptExpression)*)? /*group:}*/ /*info: name=>expressions*/;

cmlScriptLambda
    : cmlScriptSingleStatement /*info: name=>single_statement*/ # cmlScriptLambda_Single
    | cmlScriptStatementBlock /*info: name=>block*/ # cmlScriptLambda_Block
    ;

cmlScriptStatement
    : cmlScriptSingleStatement /*info: name=>single_statement*/ ';' # cmlScriptStatement_Single
    | cmlScriptStatementBlock /*info: name=>block*/ # cmlScriptStatement_Block

    | 'if' '(' cmlScriptExpression /*info: name=>condition_expression*/ ')'
        cmlScriptStatement /*info: name=>true_statement*/
        ('else' cmlScriptStatement /*info: name=>false_statement*/)? # cmlScriptStatement_If

    | 'while' '(' cmlScriptExpression /*info: name=>condition_expression*/ ')'
        cmlScriptStatement /*info: name=>while_statement*/ # cmlScriptStatement_While
    ;

cmlScriptSingleStatement
    : cmlScriptValueReference /*info: name=>value_reference*/ '=' cmlScriptExpression /*info: name=>expression*/ # cmlScriptSingleStatement_Assign
    | cmlScriptExpression /*info: name=>indirection_expression*/ '.' cmlScriptValueReference /*info: name=>value_reference*/ '=' cmlScriptExpression /*info: name=>expression*/ # cmlScriptSingleStatement_IndirectAssign

    | cmlScriptFunctionCall /*info: name=>function_call*/ # cmlScriptSingleStatement_FunctionCall
    | cmlScriptExpression /*info: name=>indirection_expression*/ '.' cmlScriptFunctionCall /*info: name=>function_call*/ # cmlScriptSingleStatement_IndirectFunctionCall
    ;

cmlScriptStatementBlock : '{' cmlScriptStatement* /*info: name=>statements*/ '}';






INT /*info: type=>int*/ : ('-' | '+')? [0-9]+;
FLOAT /*info: type=>float*/ : ('-' | '+')? [0-9]* '.'? [0-9]+ 'f';
DOUBLE /*info: type=>double*/ : ('-' | '+')? [0-9]* '.' [0-9]+;

NULL : 'null';
BOOL /*info: type=>bool*/ : ('true' | 'false' | 'on' | 'off' | 'yes' | 'no');
STRING : ('"' ('\\"'|.)*? '"' | '\'' ('\\\''|.)*? '\'');

ID : [A-Za-z_][A-Za-z0-9_]*;

COMMENT : '//' .*? [\r\n] -> skip;
MULTILINE_COMMENT : '/*' .*? '*/' -> skip;

WHITESPACE : [ \r\n\t]+ -> skip;