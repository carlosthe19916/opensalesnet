using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace org.ahren.manager.api.ef
{

    public class Rule
    {       
        public string ComparisonPredicate { get; set; }

        public ExpressionType ComparisonOperator { get; set; }

        public string ComparisonValue { get; set; }

        public Rule(string comparisonPredicate, ExpressionType comparisonOperator, string comparisonValue)
        {
            ComparisonPredicate = comparisonPredicate;
            ComparisonOperator = comparisonOperator;
            ComparisonValue = comparisonValue;
        }
    }
}
