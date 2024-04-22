using System;

public class Message {
    public int localmessageid { get; set; }
    [Obsolete("Not used in client! Always zero")]
    public int messageid { get; set; }

    public int chatid { get; set; }
    public MessageFlag flag { get; set; }
    public string text { get; set; }
    public DateTime sentdate { get; set; }
    
    [Obsolete("Not used in client! Always zero")]
    public int senderid { get; set; }
    public string sender { get; set; }

    [Obsolete("Not used in client! Always -1")]
    public int replyid { get; set; }

    
}