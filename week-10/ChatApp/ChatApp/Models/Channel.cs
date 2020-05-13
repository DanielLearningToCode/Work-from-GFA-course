using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class Channel
    {
		/*[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]*/
		[Key]
		public int ChannelId{ get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Admin { get; set; }
		public string Iconurl { get; set; }
		public string Secret { get; set; }
	}
}