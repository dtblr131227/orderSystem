//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace orderSystem2
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string orderDateTime { get; set; }
        public string ClientAddress { get; set; }
        public string ClientName { get; set; }
        public int ClientPhone { get; set; }
    
        public virtual user user { get; set; }
    }
}
