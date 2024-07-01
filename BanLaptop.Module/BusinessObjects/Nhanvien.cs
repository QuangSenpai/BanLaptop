﻿using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BanLaptop.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("nhanvien")]
    [System.ComponentModel.DisplayName("Nhân viên")]
    [DefaultProperty("Hoten")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Nhanvien : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Nhanvien(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        private string _Taikhoan;
        [XafDisplayName("Tài khoản"), Size(50)]
        public string Taikhoan
        {
            get { return _Taikhoan; }
            set { SetPropertyValue<string>(nameof(Taikhoan), ref _Taikhoan, value); }
        }

        private string _Hoten;
        [XafDisplayName("Họ và Tên"), Size(255)]
        public string Hoten
        {
            get { return _Hoten; }
            set { SetPropertyValue<string>(nameof(Hoten), ref _Hoten, value); }
        }

        private string _Diachi;
        [XafDisplayName("Địa chỉ"), Size(255)]
        public string Diachi
        {
            get { return _Diachi; }
            set { SetPropertyValue<string>(nameof(Diachi), ref _Diachi, value); }
        }

        private string _Dienthoai;
        [XafDisplayName("Điện thoại"), Size(10)]
        public string Dienthoai
        {
            get { return _Dienthoai; }
            set { SetPropertyValue<string>(nameof(Dienthoai), ref _Dienthoai, value); }
        }

        private string _Email;
        [XafDisplayName("Email"), Size(255)]
        public string Email
        {
            get { return _Email; }
            set { SetPropertyValue<string>(nameof(Email), ref _Email, value); }
        }

        private string _Ghichu;
        [XafDisplayName("Ghi chú"), Size(255)]
        public string Ghichu
        {
            get { return _Ghichu; }
            set { SetPropertyValue<string>(nameof(Ghichu), ref _Ghichu, value); }
        }

        [DevExpress.Xpo.Aggregated, Association("Kt-chi")]
        [XafDisplayName("Phiếu chi")]
        public XPCollection<Phieuchi> Phieuchis
        {
            get { return GetCollection<Phieuchi>(nameof(Phieuchis)); }
        }

        [DevExpress.Xpo.Aggregated, Association("Kt-thu")]
        [XafDisplayName("Phiếu thu")]
        public XPCollection<Phieuthu> Phieuthus
        {
            get { return GetCollection<Phieuthu>(nameof(Phieuthus)); }
        }
    }
}