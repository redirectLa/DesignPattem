using System;
using System.Collections;

namespace FlyweightPattern
{
    //抽象网站类
    public abstract class WebSite
    {
        public abstract void Use(User user);
    }

    //用户
    public class User
    {
        private string name;

        public User(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }

    //具体网站类
    public class ConcreteWebSite : WebSite
    {
        private string name;

        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine("网站分类：{0}，用户：{1}", name, user.Name);
        }
    }

    public class WebSiteFactory
    {
        private Hashtable webSites = new Hashtable();

        public WebSite GetWebSite(string key)
        {
            if (!webSites.Contains(key))
                webSites.Add(key, new ConcreteWebSite(key));
            return (WebSite)webSites[key];
        }

        public int GetWebSiteCount()
        {
            return webSites.Count;
        }
    }
}