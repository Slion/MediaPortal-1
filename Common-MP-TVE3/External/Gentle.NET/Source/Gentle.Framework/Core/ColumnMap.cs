/*
 * 
 * Copyright (C) 2004 Morten Mertner
 * 
 * This library is free software; you can redistribute it and/or modify it 
 * under the terms of the GNU Lesser General Public License 2.1 or later, as
 * published by the Free Software Foundation. See the included License.txt
 * or http://www.gnu.org/copyleft/lesser.html for details.
 *
 * $Id: ColumnMap.cs 646 2005-02-21 20:28:03Z mm $
 */

namespace Gentle.Framework
{
	/*
	/// <summary>
	/// A small structure for storing metadata for table columns (fields).
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class ColumnMap
	{
		private const long NO_DBTYPE = -1;
		private TableMap map; // the map to which this instance belongs
		private string columnName;
		private bool isReservedWord = false;
		private bool isNullable = false;
		private bool isAutoGenerated = false;
		private bool isPrimaryKey = false;
		private string foreignKeyTableName = null;
		private string foreignKeyColumnName = null;
		private Hashtable dbTypes; // the database type of the field (indexed by provider name)
		private int size; // the database field size/length
		
		#region Constructor(s)
		/// <summary>
		/// Constructor for fields using information obtained directly from the database (no property info).
		/// </summary>
		public ColumnMap( TableMap map, string columnName )
		{
			this.map = map;
			this.columnName = GetColumnName( columnName );
			// also initialize this field so we can check if it has been set
			this.dbTypes = new Hashtable();
		}
		#endregion

		#region Internal Methods
		public static string GetColumnName( string columnName )
		{
			columnName = columnName.Trim();
			SqlFactory sf = Broker.GetSqlFactory();
			if( sf.IsReservedWord( columnName ) || columnName.IndexOf( " " ) != -1 )
				// save a quoted version of the column name 
				return sf.QuoteReservedWord( columnName );
			else
				return columnName;
		}
		internal void SetDbType( string providerName, long dbType )
		{
			this.dbTypes[ providerName ] = dbType;
		}
		internal void SetDbType( string providerName, DbType dbType )
		{
			this.dbTypes[ providerName ] = (long) dbType;
		}
		internal void SetDbType( string providerName, string dbType, bool isUnsigned )
		{
			SqlFactory sf = Broker.GetSqlFactory();
			this.dbTypes[ providerName ] = sf.GetDbType( dbType, isUnsigned );
		}
		internal void SetIsNullable( bool isNullable )
		{
			this.isNullable = isNullable;
		}
		internal void SetSize( int size )
		{
			this.size = size;
		}
		internal void SetIsAutoGenerated( bool isAutoGenerated )
		{
			this.isAutoGenerated = isAutoGenerated;
		}
		internal void SetIsPrimaryKey( bool isPrimaryKey )
		{
			this.isPrimaryKey = isPrimaryKey;
		}
		internal void SetForeignKeyTableName( string foreignKeyTableName )
		{
			SqlFactory sf = Broker.GetSqlFactory();
			foreignKeyTableName = foreignKeyTableName.Trim();
			if( sf.IsReservedWord( foreignKeyTableName ) )
				this.foreignKeyTableName = sf.QuoteReservedWord( foreignKeyTableName );
			else
				this.foreignKeyTableName = foreignKeyTableName;
		}
		internal void SetForeignKeyColumnName( string foreignKeyColumnName )
		{
			SqlFactory sf = Broker.GetSqlFactory();
			foreignKeyColumnName = foreignKeyColumnName.Trim();
			if( sf.IsReservedWord( foreignKeyTableName ) )
				this.foreignKeyColumnName = sf.QuoteReservedWord( foreignKeyColumnName );
			else
				this.foreignKeyColumnName = foreignKeyColumnName;
		}
		#endregion

		#region Properties
		/// <summary>
		/// The column name this instance represents.
		/// </summary>
		public string ColumnName
		{
			get{ return columnName; }
		}
		/// <summary>
		/// The database type of this field (the rdbms-specific type enumeration converted to long).
		/// </summary>
		public long GetDbType( string providerName )
		{
			return (long) this.dbTypes[ providerName ];
		}
		/// <summary>
		/// A boolean indicating whether the name of this field is reserved and needs special quoting.
		/// </summary>
		public bool IsReservedWord
		{
			get{ return isReservedWord; }
		}
		/// <summary>
		/// The size of this field or 0 if not applicable or unknown.
		/// </summary>
		public int Size
		{
			get{ return size; }
		}
		/// <summary>
		/// A boolean indicating whether the database column accepts nulls.
		/// </summary>
		public bool IsNullable
		{
			get{ return isNullable; }
		}
		/// <summary>
		/// A boolean indicating whether this field is autogenerated by the database on insert.
		/// </summary>
		public bool IsAutoGenerated
		{
			get{ return isAutoGenerated; }
		}
		/// <summary>
		/// A boolean indicating whether this is a primary key field.
		/// </summary>
		public bool IsPrimaryKey
		{
			get{ return isPrimaryKey; }
		}
		/// <summary>
		/// A boolean indicating whether this is a foreign key field.
		/// </summary>
		public bool IsForeignKey
		{
			get{ return foreignKeyColumnName != null && foreignKeyTableName != null; }
		}
		/// <summary>
		/// The name of the table for foreign keys and null otherwise.
		/// </summary>
		public string ForeignKeyTableName
		{
			get{ return foreignKeyTableName; }
		}
		/// <summary>
		/// The name of the table column for foreign keys and null otherwise.
		/// </summary>
		public string ForeignKeyColumnName
		{
			get{ return foreignKeyColumnName; }
		}
		#endregion
	}
	*/
}