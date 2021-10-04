using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Post
    {
        public DateTime Moment { get; set; } //Tipo DateTime
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; } //Quantidades de likes
        public List<Comment> Comments { get; set; } = new List<Comment>(); //Uma lista de comentarios. Obrigar a instanciação da lista.

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes) //Alista não é passada para o construtor.
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) //Operação para adicionar comment.
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) //Remover comment.
        {
            Comments.Remove(comment);
        }

        public override string ToString() //Definir como o post será convertido para string. 
        {
            //String builder, faz a montagem do string. 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            //Percorrer a lista de comentarios
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
