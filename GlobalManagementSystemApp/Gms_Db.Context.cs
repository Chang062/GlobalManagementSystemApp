﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalManagementSystemApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Gms_DbEntities : DbContext
    {
        public Gms_DbEntities()
            : base("name=Gms_DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Courier> Couriers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Product_details> Product_details { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Transaction_info> Transaction_info { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Parish> Parishes { get; set; }
        public virtual DbSet<Transactions_View> Transactions_View { get; set; }
    
        [DbFunction("Gms_DbEntities", "Contractors")]
        public virtual IQueryable<Contractors_Result> Contractors()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Contractors_Result>("[Gms_DbEntities].[Contractors]()");
        }
    
        [DbFunction("Gms_DbEntities", "Find_delivery_by_date")]
        public virtual IQueryable<Find_delivery_by_date_Result> Find_delivery_by_date(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Find_delivery_by_date_Result>("[Gms_DbEntities].[Find_delivery_by_date](@date)", dateParameter);
        }
    
        [DbFunction("Gms_DbEntities", "Find_delivery_by_id")]
        public virtual IQueryable<Find_delivery_by_id_Result> Find_delivery_by_id(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Find_delivery_by_id_Result>("[Gms_DbEntities].[Find_delivery_by_id](@ID)", iDParameter);
        }
    
        [DbFunction("Gms_DbEntities", "Find_transaction_by_date")]
        public virtual IQueryable<Find_transaction_by_date_Result> Find_transaction_by_date(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Find_transaction_by_date_Result>("[Gms_DbEntities].[Find_transaction_by_date](@date)", dateParameter);
        }
    
        [DbFunction("Gms_DbEntities", "Find_transactions_by_id")]
        public virtual IQueryable<Find_transactions_by_id_Result> Find_transactions_by_id(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Find_transactions_by_id_Result>("[Gms_DbEntities].[Find_transactions_by_id](@ID)", iDParameter);
        }
    
        [DbFunction("Gms_DbEntities", "Product_sold")]
        public virtual IQueryable<Product_sold_Result> Product_sold(Nullable<System.DateTime> date1, Nullable<System.DateTime> date2)
        {
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("Date1", date1) :
                new ObjectParameter("Date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("Date2", date2) :
                new ObjectParameter("Date2", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Product_sold_Result>("[Gms_DbEntities].[Product_sold](@Date1, @Date2)", date1Parameter, date2Parameter);
        }
    
        public virtual int delete_customer(Nullable<int> custID)
        {
            var custIDParameter = custID.HasValue ?
                new ObjectParameter("custID", custID) :
                new ObjectParameter("custID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delete_customer", custIDParameter);
        }
    
        public virtual int Find_product(Nullable<int> prod_ID)
        {
            var prod_IDParameter = prod_ID.HasValue ?
                new ObjectParameter("Prod_ID", prod_ID) :
                new ObjectParameter("Prod_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Find_product", prod_IDParameter);
        }
    
        public virtual int Insert_customer(string fname, string lname, string addr_line1, string addr_line2, string email_addr, Nullable<decimal> contact_no, Nullable<int> payment_ID, ObjectParameter iD)
        {
            var fnameParameter = fname != null ?
                new ObjectParameter("Fname", fname) :
                new ObjectParameter("Fname", typeof(string));
    
            var lnameParameter = lname != null ?
                new ObjectParameter("Lname", lname) :
                new ObjectParameter("Lname", typeof(string));
    
            var addr_line1Parameter = addr_line1 != null ?
                new ObjectParameter("Addr_line1", addr_line1) :
                new ObjectParameter("Addr_line1", typeof(string));
    
            var addr_line2Parameter = addr_line2 != null ?
                new ObjectParameter("Addr_line2", addr_line2) :
                new ObjectParameter("Addr_line2", typeof(string));
    
            var email_addrParameter = email_addr != null ?
                new ObjectParameter("Email_addr", email_addr) :
                new ObjectParameter("Email_addr", typeof(string));
    
            var contact_noParameter = contact_no.HasValue ?
                new ObjectParameter("Contact_no", contact_no) :
                new ObjectParameter("Contact_no", typeof(decimal));
    
            var payment_IDParameter = payment_ID.HasValue ?
                new ObjectParameter("Payment_ID", payment_ID) :
                new ObjectParameter("Payment_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_customer", fnameParameter, lnameParameter, addr_line1Parameter, addr_line2Parameter, email_addrParameter, contact_noParameter, payment_IDParameter, iD);
        }
    
        public virtual int Insert_payment_info(Nullable<decimal> card_num, Nullable<System.DateTime> exp_date, Nullable<int> network_ID, ObjectParameter iD)
        {
            var card_numParameter = card_num.HasValue ?
                new ObjectParameter("Card_num", card_num) :
                new ObjectParameter("Card_num", typeof(decimal));
    
            var exp_dateParameter = exp_date.HasValue ?
                new ObjectParameter("Exp_date", exp_date) :
                new ObjectParameter("Exp_date", typeof(System.DateTime));
    
            var network_IDParameter = network_ID.HasValue ?
                new ObjectParameter("Network_ID", network_ID) :
                new ObjectParameter("Network_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_payment_info", card_numParameter, exp_dateParameter, network_IDParameter, iD);
        }
    
        public virtual int InsertTransaction(Nullable<int> customerID, ObjectParameter iD)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertTransaction", customerIDParameter, iD);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int Update_inventory(Nullable<int> prod_ID, Nullable<int> qty)
        {
            var prod_IDParameter = prod_ID.HasValue ?
                new ObjectParameter("Prod_ID", prod_ID) :
                new ObjectParameter("Prod_ID", typeof(int));
    
            var qtyParameter = qty.HasValue ?
                new ObjectParameter("Qty", qty) :
                new ObjectParameter("Qty", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_inventory", prod_IDParameter, qtyParameter);
        }
    }
}