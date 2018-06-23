using System.Collections.Generic;
using Antlr4.Runtime;
using Microsoft.Pc.TypeChecker.AST.Declarations;

namespace Microsoft.Pc.TypeChecker.AST.Statements
{
    public class FunCallStmt : IPStmt
    {
        public FunCallStmt(ParserRuleContext sourceLocation, Function fun, IReadOnlyList<IPExpr> argsList)
        {
            SourceLocation = sourceLocation;
            Fun = fun;
            ArgsList = argsList;
        }

        public Function Fun { get; }
        public IReadOnlyList<IPExpr> ArgsList { get; }

        public ParserRuleContext SourceLocation { get; }
    }
}