using System;

namespace ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        protected Handler successor = null;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandlerRequest(int request);
    }

    public class ConcreteHandler1 : Handler
    {

        public override void HandlerRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0}处理请求{1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }
    public class ConcreteHandler2 : Handler
    {

        public override void HandlerRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0}处理请求{1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }

    public class ConcreteHandler3 : Handler
    {

        public override void HandlerRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0}处理请求{1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandlerRequest(request);
            }
        }
    }
}