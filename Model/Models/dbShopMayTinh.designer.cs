﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopMayTinh.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SHOPMAYTINH")]
	public partial class dbShopMayTinhDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertADMIN(ADMIN instance);
    partial void UpdateADMIN(ADMIN instance);
    partial void DeleteADMIN(ADMIN instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    partial void InsertCHITIETDONHANG(CHITIETDONHANG instance);
    partial void UpdateCHITIETDONHANG(CHITIETDONHANG instance);
    partial void DeleteCHITIETDONHANG(CHITIETDONHANG instance);
    partial void InsertDANHMUC(DANHMUC instance);
    partial void UpdateDANHMUC(DANHMUC instance);
    partial void DeleteDANHMUC(DANHMUC instance);
    partial void InsertDONHANG(DONHANG instance);
    partial void UpdateDONHANG(DONHANG instance);
    partial void DeleteDONHANG(DONHANG instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertPHANQUYEN(PHANQUYEN instance);
    partial void UpdatePHANQUYEN(PHANQUYEN instance);
    partial void DeletePHANQUYEN(PHANQUYEN instance);
    #endregion
		
		public dbShopMayTinhDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SHOPMAYTINHConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbShopMayTinhDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbShopMayTinhDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbShopMayTinhDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbShopMayTinhDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ADMIN> ADMINs
		{
			get
			{
				return this.GetTable<ADMIN>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<CHITIETDONHANG> CHITIETDONHANGs
		{
			get
			{
				return this.GetTable<CHITIETDONHANG>();
			}
		}
		
		public System.Data.Linq.Table<DANHMUC> DANHMUCs
		{
			get
			{
				return this.GetTable<DANHMUC>();
			}
		}
		
		public System.Data.Linq.Table<DONHANG> DONHANGs
		{
			get
			{
				return this.GetTable<DONHANG>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<PHANQUYEN> PHANQUYENs
		{
			get
			{
				return this.GetTable<PHANQUYEN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ADMIN")]
	public partial class ADMIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _Pass;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    #endregion
		
		public ADMIN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(100)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private string _TenSP;
		
		private int _MaDM;
		
		private string _HangSX;
		
		private string _TinhTrang;
		
		private System.Nullable<double> _DonGia;
		
		private System.Nullable<System.DateTime> _NgayNhap;
		
		private string _HinhAnh;
		
		private string _MoTa;
		
		private EntitySet<CHITIETDONHANG> _CHITIETDONHANGs;
		
		private EntityRef<DANHMUC> _DANHMUC;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnMaDMChanging(int value);
    partial void OnMaDMChanged();
    partial void OnHangSXChanging(string value);
    partial void OnHangSXChanged();
    partial void OnTinhTrangChanging(string value);
    partial void OnTinhTrangChanged();
    partial void OnDonGiaChanging(System.Nullable<double> value);
    partial void OnDonGiaChanged();
    partial void OnNgayNhapChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayNhapChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    #endregion
		
		public SANPHAM()
		{
			this._CHITIETDONHANGs = new EntitySet<CHITIETDONHANG>(new Action<CHITIETDONHANG>(this.attach_CHITIETDONHANGs), new Action<CHITIETDONHANG>(this.detach_CHITIETDONHANGs));
			this._DANHMUC = default(EntityRef<DANHMUC>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(500)")]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDM", DbType="Int NOT NULL")]
		public int MaDM
		{
			get
			{
				return this._MaDM;
			}
			set
			{
				if ((this._MaDM != value))
				{
					if (this._DANHMUC.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDMChanging(value);
					this.SendPropertyChanging();
					this._MaDM = value;
					this.SendPropertyChanged("MaDM");
					this.OnMaDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HangSX", DbType="NVarChar(50)")]
		public string HangSX
		{
			get
			{
				return this._HangSX;
			}
			set
			{
				if ((this._HangSX != value))
				{
					this.OnHangSXChanging(value);
					this.SendPropertyChanging();
					this._HangSX = value;
					this.SendPropertyChanged("HangSX");
					this.OnHangSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="VarChar(3)")]
		public string TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Float")]
		public System.Nullable<double> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayNhap", DbType="Date")]
		public System.Nullable<System.DateTime> NgayNhap
		{
			get
			{
				return this._NgayNhap;
			}
			set
			{
				if ((this._NgayNhap != value))
				{
					this.OnNgayNhapChanging(value);
					this.SendPropertyChanging();
					this._NgayNhap = value;
					this.SendPropertyChanged("NgayNhap");
					this.OnNgayNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="NVarChar(2000)")]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(1000)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CHITIETDONHANG", Storage="_CHITIETDONHANGs", ThisKey="MaSP", OtherKey="MaSP")]
		public EntitySet<CHITIETDONHANG> CHITIETDONHANGs
		{
			get
			{
				return this._CHITIETDONHANGs;
			}
			set
			{
				this._CHITIETDONHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DANHMUC_SANPHAM", Storage="_DANHMUC", ThisKey="MaDM", OtherKey="MaDM", IsForeignKey=true)]
		public DANHMUC DANHMUC
		{
			get
			{
				return this._DANHMUC.Entity;
			}
			set
			{
				DANHMUC previousValue = this._DANHMUC.Entity;
				if (((previousValue != value) 
							|| (this._DANHMUC.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DANHMUC.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._DANHMUC.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MaDM = value.MaDM;
					}
					else
					{
						this._MaDM = default(int);
					}
					this.SendPropertyChanged("DANHMUC");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_CHITIETDONHANGs(CHITIETDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = this;
		}
		
		private void detach_CHITIETDONHANGs(CHITIETDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETDONHANG")]
	public partial class CHITIETDONHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private int _MaDH;
		
		private System.Nullable<int> _Soluong;
		
		private System.Nullable<double> _DonGia;
		
		private System.Nullable<double> _TongCong;
		
		private EntityRef<SANPHAM> _SANPHAM;
		
		private EntityRef<DONHANG> _DONHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnMaDHChanging(int value);
    partial void OnMaDHChanged();
    partial void OnSoluongChanging(System.Nullable<int> value);
    partial void OnSoluongChanged();
    partial void OnDonGiaChanging(System.Nullable<double> value);
    partial void OnDonGiaChanged();
    partial void OnTongCongChanging(System.Nullable<double> value);
    partial void OnTongCongChanged();
    #endregion
		
		public CHITIETDONHANG()
		{
			this._SANPHAM = default(EntityRef<SANPHAM>);
			this._DONHANG = default(EntityRef<DONHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					if (this._SANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDH", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDH
		{
			get
			{
				return this._MaDH;
			}
			set
			{
				if ((this._MaDH != value))
				{
					if (this._DONHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDHChanging(value);
					this.SendPropertyChanging();
					this._MaDH = value;
					this.SendPropertyChanged("MaDH");
					this.OnMaDHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluong", DbType="Int")]
		public System.Nullable<int> Soluong
		{
			get
			{
				return this._Soluong;
			}
			set
			{
				if ((this._Soluong != value))
				{
					this.OnSoluongChanging(value);
					this.SendPropertyChanging();
					this._Soluong = value;
					this.SendPropertyChanged("Soluong");
					this.OnSoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Float")]
		public System.Nullable<double> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongCong", DbType="Float")]
		public System.Nullable<double> TongCong
		{
			get
			{
				return this._TongCong;
			}
			set
			{
				if ((this._TongCong != value))
				{
					this.OnTongCongChanging(value);
					this.SendPropertyChanging();
					this._TongCong = value;
					this.SendPropertyChanged("TongCong");
					this.OnTongCongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CHITIETDONHANG", Storage="_SANPHAM", ThisKey="MaSP", OtherKey="MaSP", IsForeignKey=true)]
		public SANPHAM SANPHAM
		{
			get
			{
				return this._SANPHAM.Entity;
			}
			set
			{
				SANPHAM previousValue = this._SANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._SANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SANPHAM.Entity = null;
						previousValue.CHITIETDONHANGs.Remove(this);
					}
					this._SANPHAM.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONHANGs.Add(this);
						this._MaSP = value.MaSP;
					}
					else
					{
						this._MaSP = default(int);
					}
					this.SendPropertyChanged("SANPHAM");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONHANG_CHITIETDONHANG", Storage="_DONHANG", ThisKey="MaDH", OtherKey="MaDH", IsForeignKey=true)]
		public DONHANG DONHANG
		{
			get
			{
				return this._DONHANG.Entity;
			}
			set
			{
				DONHANG previousValue = this._DONHANG.Entity;
				if (((previousValue != value) 
							|| (this._DONHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DONHANG.Entity = null;
						previousValue.CHITIETDONHANGs.Remove(this);
					}
					this._DONHANG.Entity = value;
					if ((value != null))
					{
						value.CHITIETDONHANGs.Add(this);
						this._MaDH = value.MaDH;
					}
					else
					{
						this._MaDH = default(int);
					}
					this.SendPropertyChanged("DONHANG");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DANHMUC")]
	public partial class DANHMUC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDM;
		
		private string _TenDM;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDMChanging(int value);
    partial void OnMaDMChanged();
    partial void OnTenDMChanging(string value);
    partial void OnTenDMChanged();
    #endregion
		
		public DANHMUC()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDM", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDM
		{
			get
			{
				return this._MaDM;
			}
			set
			{
				if ((this._MaDM != value))
				{
					this.OnMaDMChanging(value);
					this.SendPropertyChanging();
					this._MaDM = value;
					this.SendPropertyChanged("MaDM");
					this.OnMaDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDM", DbType="NVarChar(100)")]
		public string TenDM
		{
			get
			{
				return this._TenDM;
			}
			set
			{
				if ((this._TenDM != value))
				{
					this.OnTenDMChanging(value);
					this.SendPropertyChanging();
					this._TenDM = value;
					this.SendPropertyChanged("TenDM");
					this.OnTenDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DANHMUC_SANPHAM", Storage="_SANPHAMs", ThisKey="MaDM", OtherKey="MaDM")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.DANHMUC = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.DANHMUC = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONHANG")]
	public partial class DONHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDH;
		
		private int _MaKH;
		
		private System.Nullable<System.DateTime> _NgayLap;
		
		private System.Nullable<double> _ThanhTien;
		
		private System.Nullable<System.DateTime> _NgayGiao;
		
		private System.Nullable<bool> _TinhTrangGiaoHang;
		
		private System.Nullable<bool> _DaThanhToan;
		
		private EntitySet<CHITIETDONHANG> _CHITIETDONHANGs;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDHChanging(int value);
    partial void OnMaDHChanged();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnNgayLapChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayLapChanged();
    partial void OnThanhTienChanging(System.Nullable<double> value);
    partial void OnThanhTienChanged();
    partial void OnNgayGiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayGiaoChanged();
    partial void OnTinhTrangGiaoHangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangGiaoHangChanged();
    partial void OnDaThanhToanChanging(System.Nullable<bool> value);
    partial void OnDaThanhToanChanged();
    #endregion
		
		public DONHANG()
		{
			this._CHITIETDONHANGs = new EntitySet<CHITIETDONHANG>(new Action<CHITIETDONHANG>(this.attach_CHITIETDONHANGs), new Action<CHITIETDONHANG>(this.detach_CHITIETDONHANGs));
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDH
		{
			get
			{
				return this._MaDH;
			}
			set
			{
				if ((this._MaDH != value))
				{
					this.OnMaDHChanging(value);
					this.SendPropertyChanging();
					this._MaDH = value;
					this.SendPropertyChanged("MaDH");
					this.OnMaDHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int NOT NULL")]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLap", DbType="Date")]
		public System.Nullable<System.DateTime> NgayLap
		{
			get
			{
				return this._NgayLap;
			}
			set
			{
				if ((this._NgayLap != value))
				{
					this.OnNgayLapChanging(value);
					this.SendPropertyChanging();
					this._NgayLap = value;
					this.SendPropertyChanged("NgayLap");
					this.OnNgayLapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Float")]
		public System.Nullable<double> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayGiao", DbType="Date")]
		public System.Nullable<System.DateTime> NgayGiao
		{
			get
			{
				return this._NgayGiao;
			}
			set
			{
				if ((this._NgayGiao != value))
				{
					this.OnNgayGiaoChanging(value);
					this.SendPropertyChanging();
					this._NgayGiao = value;
					this.SendPropertyChanged("NgayGiao");
					this.OnNgayGiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrangGiaoHang", DbType="Bit")]
		public System.Nullable<bool> TinhTrangGiaoHang
		{
			get
			{
				return this._TinhTrangGiaoHang;
			}
			set
			{
				if ((this._TinhTrangGiaoHang != value))
				{
					this.OnTinhTrangGiaoHangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrangGiaoHang = value;
					this.SendPropertyChanged("TinhTrangGiaoHang");
					this.OnTinhTrangGiaoHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaThanhToan", DbType="Bit")]
		public System.Nullable<bool> DaThanhToan
		{
			get
			{
				return this._DaThanhToan;
			}
			set
			{
				if ((this._DaThanhToan != value))
				{
					this.OnDaThanhToanChanging(value);
					this.SendPropertyChanging();
					this._DaThanhToan = value;
					this.SendPropertyChanged("DaThanhToan");
					this.OnDaThanhToanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONHANG_CHITIETDONHANG", Storage="_CHITIETDONHANGs", ThisKey="MaDH", OtherKey="MaDH")]
		public EntitySet<CHITIETDONHANG> CHITIETDONHANGs
		{
			get
			{
				return this._CHITIETDONHANGs;
			}
			set
			{
				this._CHITIETDONHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONHANG", Storage="_KHACHHANG", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.DONHANGs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.DONHANGs.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(int);
					}
					this.SendPropertyChanged("KHACHHANG");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_CHITIETDONHANGs(CHITIETDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONHANG = this;
		}
		
		private void detach_CHITIETDONHANGs(CHITIETDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _TenKH;
		
		private string _Email;
		
		private string _Pass;
		
		private string _Address;
		
		private string _Phone;
		
		private System.Nullable<int> _MaQuyen;
		
		private EntitySet<DONHANG> _DONHANGs;
		
		private EntityRef<PHANQUYEN> _PHANQUYEN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnMaQuyenChanging(System.Nullable<int> value);
    partial void OnMaQuyenChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._DONHANGs = new EntitySet<DONHANG>(new Action<DONHANG>(this.attach_DONHANGs), new Action<DONHANG>(this.detach_DONHANGs));
			this._PHANQUYEN = default(EntityRef<PHANQUYEN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(50)")]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="NVarChar(100)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(500)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(20)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQuyen", DbType="Int")]
		public System.Nullable<int> MaQuyen
		{
			get
			{
				return this._MaQuyen;
			}
			set
			{
				if ((this._MaQuyen != value))
				{
					if (this._PHANQUYEN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaQuyenChanging(value);
					this.SendPropertyChanging();
					this._MaQuyen = value;
					this.SendPropertyChanged("MaQuyen");
					this.OnMaQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONHANG", Storage="_DONHANGs", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<DONHANG> DONHANGs
		{
			get
			{
				return this._DONHANGs;
			}
			set
			{
				this._DONHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHANQUYEN_KHACHHANG", Storage="_PHANQUYEN", ThisKey="MaQuyen", OtherKey="MaQuyen", IsForeignKey=true)]
		public PHANQUYEN PHANQUYEN
		{
			get
			{
				return this._PHANQUYEN.Entity;
			}
			set
			{
				PHANQUYEN previousValue = this._PHANQUYEN.Entity;
				if (((previousValue != value) 
							|| (this._PHANQUYEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PHANQUYEN.Entity = null;
						previousValue.KHACHHANGs.Remove(this);
					}
					this._PHANQUYEN.Entity = value;
					if ((value != null))
					{
						value.KHACHHANGs.Add(this);
						this._MaQuyen = value.MaQuyen;
					}
					else
					{
						this._MaQuyen = default(Nullable<int>);
					}
					this.SendPropertyChanged("PHANQUYEN");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHANQUYEN")]
	public partial class PHANQUYEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaQuyen;
		
		private string _TenQuyen;
		
		private EntitySet<KHACHHANG> _KHACHHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaQuyenChanging(int value);
    partial void OnMaQuyenChanged();
    partial void OnTenQuyenChanging(string value);
    partial void OnTenQuyenChanged();
    #endregion
		
		public PHANQUYEN()
		{
			this._KHACHHANGs = new EntitySet<KHACHHANG>(new Action<KHACHHANG>(this.attach_KHACHHANGs), new Action<KHACHHANG>(this.detach_KHACHHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQuyen", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaQuyen
		{
			get
			{
				return this._MaQuyen;
			}
			set
			{
				if ((this._MaQuyen != value))
				{
					this.OnMaQuyenChanging(value);
					this.SendPropertyChanging();
					this._MaQuyen = value;
					this.SendPropertyChanged("MaQuyen");
					this.OnMaQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenQuyen", DbType="NVarChar(50)")]
		public string TenQuyen
		{
			get
			{
				return this._TenQuyen;
			}
			set
			{
				if ((this._TenQuyen != value))
				{
					this.OnTenQuyenChanging(value);
					this.SendPropertyChanging();
					this._TenQuyen = value;
					this.SendPropertyChanged("TenQuyen");
					this.OnTenQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHANQUYEN_KHACHHANG", Storage="_KHACHHANGs", ThisKey="MaQuyen", OtherKey="MaQuyen")]
		public EntitySet<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this._KHACHHANGs;
			}
			set
			{
				this._KHACHHANGs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_KHACHHANGs(KHACHHANG entity)
		{
			this.SendPropertyChanging();
			entity.PHANQUYEN = this;
		}
		
		private void detach_KHACHHANGs(KHACHHANG entity)
		{
			this.SendPropertyChanging();
			entity.PHANQUYEN = null;
		}
	}
}
#pragma warning restore 1591
