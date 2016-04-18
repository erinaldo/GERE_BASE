﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2407
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace mz.erp.commontypes.data {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class tsy_TiposBilletesDataset : DataSet {
        
        private tsy_TiposBilletesDataTable tabletsy_TiposBilletes;
        
        public tsy_TiposBilletesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsy_TiposBilletesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsy_TiposBilletes"] != null)) {
                    this.Tables.Add(new tsy_TiposBilletesDataTable(ds.Tables["tsy_TiposBilletes"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public tsy_TiposBilletesDataTable tsy_TiposBilletes {
            get {
                return this.tabletsy_TiposBilletes;
            }
        }
        
        public override DataSet Clone() {
            tsy_TiposBilletesDataset cln = ((tsy_TiposBilletesDataset)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["tsy_TiposBilletes"] != null)) {
                this.Tables.Add(new tsy_TiposBilletesDataTable(ds.Tables["tsy_TiposBilletes"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tabletsy_TiposBilletes = ((tsy_TiposBilletesDataTable)(this.Tables["tsy_TiposBilletes"]));
            if ((this.tabletsy_TiposBilletes != null)) {
                this.tabletsy_TiposBilletes.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsy_TiposBilletesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsy_TiposBilletes.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsy_TiposBilletes = new tsy_TiposBilletesDataTable();
            this.Tables.Add(this.tabletsy_TiposBilletes);
        }
        
        private bool ShouldSerializetsy_TiposBilletes() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsy_TiposBilletesRowChangeEventHandler(object sender, tsy_TiposBilletesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_TiposBilletesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTipoBillete;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnValor;
            
            private DataColumn columnActivo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal tsy_TiposBilletesDataTable() : 
                    base("tsy_TiposBilletes") {
                this.InitClass();
            }
            
            internal tsy_TiposBilletesDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn IdTipoBilleteColumn {
                get {
                    return this.columnIdTipoBillete;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn ValorColumn {
                get {
                    return this.columnValor;
                }
            }
            
            internal DataColumn ActivoColumn {
                get {
                    return this.columnActivo;
                }
            }
            
            internal DataColumn FechaCreacionColumn {
                get {
                    return this.columnFechaCreacion;
                }
            }
            
            internal DataColumn IdConexionCreacionColumn {
                get {
                    return this.columnIdConexionCreacion;
                }
            }
            
            internal DataColumn UltimaModificacionColumn {
                get {
                    return this.columnUltimaModificacion;
                }
            }
            
            internal DataColumn IdConexionUltimaModificacionColumn {
                get {
                    return this.columnIdConexionUltimaModificacion;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            public tsy_TiposBilletesRow this[int index] {
                get {
                    return ((tsy_TiposBilletesRow)(this.Rows[index]));
                }
            }
            
            public event tsy_TiposBilletesRowChangeEventHandler tsy_TiposBilletesRowChanged;
            
            public event tsy_TiposBilletesRowChangeEventHandler tsy_TiposBilletesRowChanging;
            
            public event tsy_TiposBilletesRowChangeEventHandler tsy_TiposBilletesRowDeleted;
            
            public event tsy_TiposBilletesRowChangeEventHandler tsy_TiposBilletesRowDeleting;
            
            public void Addtsy_TiposBilletesRow(tsy_TiposBilletesRow row) {
                this.Rows.Add(row);
            }
            
            public tsy_TiposBilletesRow Addtsy_TiposBilletesRow(long IdTipoBillete, string Descripcion, System.Decimal Valor, bool Activo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                tsy_TiposBilletesRow rowtsy_TiposBilletesRow = ((tsy_TiposBilletesRow)(this.NewRow()));
                rowtsy_TiposBilletesRow.ItemArray = new object[] {
                        IdTipoBillete,
                        Descripcion,
                        Valor,
                        Activo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowtsy_TiposBilletesRow);
                return rowtsy_TiposBilletesRow;
            }
            
            public tsy_TiposBilletesRow FindByIdTipoBillete(long IdTipoBillete) {
                return ((tsy_TiposBilletesRow)(this.Rows.Find(new object[] {
                            IdTipoBillete})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsy_TiposBilletesDataTable cln = ((tsy_TiposBilletesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsy_TiposBilletesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTipoBillete = this.Columns["IdTipoBillete"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnValor = this.Columns["Valor"];
                this.columnActivo = this.Columns["Activo"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdTipoBillete = new DataColumn("IdTipoBillete", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoBillete);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnValor = new DataColumn("Valor", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValor);
                this.columnActivo = new DataColumn("Activo", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnActivo);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.Constraints.Add(new UniqueConstraint("tsy_TiposBilletesKey1", new DataColumn[] {
                                this.columnIdTipoBillete}, true));
                this.columnIdTipoBillete.AllowDBNull = false;
                this.columnIdTipoBillete.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnValor.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsy_TiposBilletesRow Newtsy_TiposBilletesRow() {
                return ((tsy_TiposBilletesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsy_TiposBilletesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsy_TiposBilletesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsy_TiposBilletesRowChanged != null)) {
                    this.tsy_TiposBilletesRowChanged(this, new tsy_TiposBilletesRowChangeEvent(((tsy_TiposBilletesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsy_TiposBilletesRowChanging != null)) {
                    this.tsy_TiposBilletesRowChanging(this, new tsy_TiposBilletesRowChangeEvent(((tsy_TiposBilletesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsy_TiposBilletesRowDeleted != null)) {
                    this.tsy_TiposBilletesRowDeleted(this, new tsy_TiposBilletesRowChangeEvent(((tsy_TiposBilletesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsy_TiposBilletesRowDeleting != null)) {
                    this.tsy_TiposBilletesRowDeleting(this, new tsy_TiposBilletesRowChangeEvent(((tsy_TiposBilletesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsy_TiposBilletesRow(tsy_TiposBilletesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_TiposBilletesRow : DataRow {
            
            private tsy_TiposBilletesDataTable tabletsy_TiposBilletes;
            
            internal tsy_TiposBilletesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsy_TiposBilletes = ((tsy_TiposBilletesDataTable)(this.Table));
            }
            
            public long IdTipoBillete {
                get {
                    return ((long)(this[this.tabletsy_TiposBilletes.IdTipoBilleteColumn]));
                }
                set {
                    this[this.tabletsy_TiposBilletes.IdTipoBilleteColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tabletsy_TiposBilletes.DescripcionColumn]));
                }
                set {
                    this[this.tabletsy_TiposBilletes.DescripcionColumn] = value;
                }
            }
            
            public System.Decimal Valor {
                get {
                    return ((System.Decimal)(this[this.tabletsy_TiposBilletes.ValorColumn]));
                }
                set {
                    this[this.tabletsy_TiposBilletes.ValorColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    try {
                        return ((bool)(this[this.tabletsy_TiposBilletes.ActivoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposBilletes.ActivoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsy_TiposBilletes.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposBilletes.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tabletsy_TiposBilletes.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tabletsy_TiposBilletes.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsy_TiposBilletes.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposBilletes.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsy_TiposBilletes.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposBilletes.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsy_TiposBilletes.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposBilletes.RowIdColumn] = value;
                }
            }
            
            public bool IsActivoNull() {
                return this.IsNull(this.tabletsy_TiposBilletes.ActivoColumn);
            }
            
            public void SetActivoNull() {
                this[this.tabletsy_TiposBilletes.ActivoColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsy_TiposBilletes.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsy_TiposBilletes.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_TiposBilletes.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsy_TiposBilletes.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_TiposBilletes.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsy_TiposBilletes.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsy_TiposBilletes.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsy_TiposBilletes.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_TiposBilletesRowChangeEvent : EventArgs {
            
            private tsy_TiposBilletesRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsy_TiposBilletesRowChangeEvent(tsy_TiposBilletesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsy_TiposBilletesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}