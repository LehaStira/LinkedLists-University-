using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithmsApp
{
    public class Node<T>
    {
       /* private T data;
        private Node<T> next;

       public Node(T data, Node<T> next=null)
        {
           this.data = data;
           this.next = next;
        }

        /// <summary>
        /// ссылка на следующий элемент
        /// </summary>
        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
        /// <summary>
        /// данные узла
        /// </summary>
        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }*/
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}
