using System;
using System.Collections.Generic;
using System.Linq;

namespace StackOverflowQuestions
{
    public class FasterLinqQuery
    {
        public class A
        {
            public DateTime Date;
        }

        public void solution(List<A> listObject, DateTime asOfDate)
        {
            var maxDate = listObject.Max(r => r.Date <= asOfDate ? r.Date : DateTime.MinValue);

            var item = listObject.FirstOrDefault(r => r.Date == maxDate);
        }
    }
}