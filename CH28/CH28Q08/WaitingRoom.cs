using System;
using System.Collections.Generic;
using System.Text;

namespace CH28Q08
{
    internal class WaitingRoom
    {
        private Queue<Request> order = new Queue<Request>();
        private Dictionary<string, Request> active = new Dictionary<string, Request>();
        public bool Register(string name)
        {
            if (active.ContainsKey(name))
            {
                return false;
            }
            Request request = new Request(name);
            active.Add(name, request);
            order.Enqueue(request);

            return true;
        }

        public bool Cancel(string name)
        {
            if(!active.ContainsKey(name))
            {
                return false;
            }
            active.Remove(name);
            return true;
        }
        public bool Call(out string name)
        {
            while (order.Count > 0)
            {
                Request request = order.Dequeue();
                if (IsActive(request))
                {
                    active.Remove(request.Name);
                    name = request.Name;
                    return true;
                }
            }
            name = null;
            return false;
        }
        private bool IsActive(Request request)
        {
            return active.TryGetValue(request.Name, out Request current) && 
                ReferenceEquals(request, current);
        }
        public string Pending() 
        {
            List<string> names = new List<string>();
            foreach (Request request in order)
            {
                if (IsActive(request))
                {
                    names.Add(request.Name);
                }
            }
            return string.Join(", ", names);
        }

    }

}
