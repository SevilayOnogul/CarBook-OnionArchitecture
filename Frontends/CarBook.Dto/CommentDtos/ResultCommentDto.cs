using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.CommentDtos
{
    public class ResultCommentDto
    {
        public int CommentID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public int BlogID { get; set; }

        public string NameInitials
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Name)) return "??";

                var parts = Name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 1) return parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpper();

                return (parts[0][0].ToString() + parts[parts.Length - 1][0].ToString()).ToUpper();
            }
        }
       
    }
}
