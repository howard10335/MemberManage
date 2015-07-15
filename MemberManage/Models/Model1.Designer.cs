﻿//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace MemberManage.Models
{
    #region 內容
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    public partial class MemberManageEntities : ObjectContext
    {
        #region 建構函式
    
        /// <summary>
        /// 使用在應用程式組態檔的 'MemberManageEntities' 區段中找到的連接字串，初始化新的 MemberManageEntities 物件。
        /// </summary>
        public MemberManageEntities() : base("name=MemberManageEntities", "MemberManageEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 MemberManageEntities 物件。
        /// </summary>
        public MemberManageEntities(string connectionString) : base(connectionString, "MemberManageEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 MemberManageEntities 物件。
        /// </summary>
        public MemberManageEntities(EntityConnection connection) : base(connection, "MemberManageEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 部分方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        public ObjectSet<Member> Member
        {
            get
            {
                if ((_Member == null))
                {
                    _Member = base.CreateObjectSet<Member>("Member");
                }
                return _Member;
            }
        }
        private ObjectSet<Member> _Member;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 將新物件加入 Member EntitySet 的方法已被取代。請考慮改為使用關聯的 ObjectSet&lt;T&gt; 屬性的 .Add 方法。
        /// </summary>
        public void AddToMember(Member member)
        {
            base.AddObject("Member", member);
        }

        #endregion

    }

    #endregion

    #region 實體
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MemberManageModel", Name="Member")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Member : EntityObject
    {
        #region Factory 方法
    
        /// <summary>
        /// 建立新 Member 物件。
        /// </summary>
        /// <param name="id">ID 屬性的初始值。</param>
        /// <param name="account">Account 屬性的初始值。</param>
        /// <param name="password">Password 屬性的初始值。</param>
        /// <param name="chName">ChName 屬性的初始值。</param>
        /// <param name="nickName">NickName 屬性的初始值。</param>
        /// <param name="email">Email 屬性的初始值。</param>
        /// <param name="isAdmin">IsAdmin 屬性的初始值。</param>
        /// <param name="emotionIcon">EmotionIcon 屬性的初始值。</param>
        /// <param name="createTime">CreateTime 屬性的初始值。</param>
        public static Member CreateMember(global::System.Int32 id, global::System.String account, global::System.String password, global::System.String chName, global::System.String nickName, global::System.String email, global::System.Boolean isAdmin, global::System.Int32 emotionIcon, global::System.DateTime createTime)
        {
            Member member = new Member();
            member.ID = id;
            member.Account = account;
            member.Password = password;
            member.ChName = chName;
            member.NickName = nickName;
            member.Email = email;
            member.IsAdmin = isAdmin;
            member.EmotionIcon = emotionIcon;
            member.CreateTime = createTime;
            return member;
        }

        #endregion

        #region 基本屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Account
        {
            get
            {
                return _Account;
            }
            set
            {
                OnAccountChanging(value);
                ReportPropertyChanging("Account");
                _Account = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Account");
                OnAccountChanged();
            }
        }
        private global::System.String _Account;
        partial void OnAccountChanging(global::System.String value);
        partial void OnAccountChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ChName
        {
            get
            {
                return _ChName;
            }
            set
            {
                OnChNameChanging(value);
                ReportPropertyChanging("ChName");
                _ChName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ChName");
                OnChNameChanged();
            }
        }
        private global::System.String _ChName;
        partial void OnChNameChanging(global::System.String value);
        partial void OnChNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NickName
        {
            get
            {
                return _NickName;
            }
            set
            {
                OnNickNameChanging(value);
                ReportPropertyChanging("NickName");
                _NickName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NickName");
                OnNickNameChanged();
            }
        }
        private global::System.String _NickName;
        partial void OnNickNameChanging(global::System.String value);
        partial void OnNickNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsAdmin
        {
            get
            {
                return _IsAdmin;
            }
            set
            {
                OnIsAdminChanging(value);
                ReportPropertyChanging("IsAdmin");
                _IsAdmin = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsAdmin");
                OnIsAdminChanged();
            }
        }
        private global::System.Boolean _IsAdmin;
        partial void OnIsAdminChanging(global::System.Boolean value);
        partial void OnIsAdminChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmotionIcon
        {
            get
            {
                return _EmotionIcon;
            }
            set
            {
                OnEmotionIconChanging(value);
                ReportPropertyChanging("EmotionIcon");
                _EmotionIcon = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EmotionIcon");
                OnEmotionIconChanged();
            }
        }
        private global::System.Int32 _EmotionIcon;
        partial void OnEmotionIconChanging(global::System.Int32 value);
        partial void OnEmotionIconChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AuthCode
        {
            get
            {
                return _AuthCode;
            }
            set
            {
                OnAuthCodeChanging(value);
                ReportPropertyChanging("AuthCode");
                _AuthCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AuthCode");
                OnAuthCodeChanged();
            }
        }
        private global::System.String _AuthCode;
        partial void OnAuthCodeChanging(global::System.String value);
        partial void OnAuthCodeChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreateTime
        {
            get
            {
                return _CreateTime;
            }
            set
            {
                OnCreateTimeChanging(value);
                ReportPropertyChanging("CreateTime");
                _CreateTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreateTime");
                OnCreateTimeChanged();
            }
        }
        private global::System.DateTime _CreateTime;
        partial void OnCreateTimeChanging(global::System.DateTime value);
        partial void OnCreateTimeChanged();

        #endregion

    
    }

    #endregion

    
}