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
    public class tsy_TiposDeComprobantesCategoriaIvaDataset : DataSet {
        
        private tsy_TiposDeComprobantesCategoriaIvaDataTable tabletsy_TiposDeComprobantesCategoriaIva;
        
        public tsy_TiposDeComprobantesCategoriaIvaDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsy_TiposDeComprobantesCategoriaIvaDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsy_TiposDeComprobantesCategoriaIva"] != null)) {
                    this.Tables.Add(new tsy_TiposDeComprobantesCategoriaIvaDataTable(ds.Tables["tsy_TiposDeComprobantesCategoriaIva"]));
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
        public tsy_TiposDeComprobantesCategoriaIvaDataTable tsy_TiposDeComprobantesCategoriaIva {
            get {
                return this.tabletsy_TiposDeComprobantesCategoriaIva;
            }
        }
        
        public override DataSet Clone() {
            tsy_TiposDeComprobantesCategoriaIvaDataset cln = ((tsy_TiposDeComprobantesCategoriaIvaDataset)(base.Clone()));
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
            if ((ds.Tables["tsy_TiposDeComprobantesCategoriaIva"] != null)) {
                this.Tables.Add(new tsy_TiposDeComprobantesCategoriaIvaDataTable(ds.Tables["tsy_TiposDeComprobantesCategoriaIva"]));
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
            this.tabletsy_TiposDeComprobantesCategoriaIva = ((tsy_TiposDeComprobantesCategoriaIvaDataTable)(this.Tables["tsy_TiposDeComprobantesCategoriaIva"]));
            if ((this.tabletsy_TiposDeComprobantesCategoriaIva != null)) {
                this.tabletsy_TiposDeComprobantesCategoriaIva.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsy_TiposDeComprobantesCategoriaIvaDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsy_TiposDeComprobantesCategoriaIva.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsy_TiposDeComprobantesCategoriaIva = new tsy_TiposDeComprobantesCategoriaIvaDataTable();
            this.Tables.Add(this.tabletsy_TiposDeComprobantesCategoriaIva);
        }
        
        private bool ShouldSerializetsy_TiposDeComprobantesCategoriaIva() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsy_TiposDeComprobantesCategoriaIvaRowChangeEventHandler(object sender, tsy_TiposDeComprobantesCategoriaIvaRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_TiposDeComprobantesCategoriaIvaDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTipoDeComprobante;
            
            private DataColumn columnIdCategoriaIva;
            
            private DataColumn columnActivo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal tsy_TiposDeComprobantesCategoriaIvaDataTable() : 
                    base("tsy_TiposDeComprobantesCategoriaIva") {
                this.InitClass();
            }
            
            internal tsy_TiposDeComprobantesCategoriaIvaDataTable(DataTable table) : 
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
            
            internal DataColumn IdTipoDeComprobanteColumn {
                get {
                    return this.columnIdTipoDeComprobante;
                }
            }
            
            internal DataColumn IdCategoriaIvaColumn {
                get {
                    return this.columnIdCategoriaIva;
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
            
            internal DataColumn IdReservadoColumn {
                get {
                    return this.columnIdReservado;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            public tsy_TiposDeComprobantesCategoriaIvaRow this[int index] {
                get {
                    return ((tsy_TiposDeComprobantesCategoriaIvaRow)(this.Rows[index]));
                }
            }
            
            public event tsy_TiposDeComprobantesCategoriaIvaRowChangeEventHandler tsy_TiposDeComprobantesCategoriaIvaRowChanged;
            
            public event tsy_TiposDeComprobantesCategoriaIvaRowChangeEventHandler tsy_TiposDeComprobantesCategoriaIvaRowChanging;
            
            public event tsy_TiposDeComprobantesCategoriaIvaRowChangeEventHandler tsy_TiposDeComprobantesCategoriaIvaRowDeleted;
            
            public event tsy_TiposDeComprobantesCategoriaIvaRowChangeEventHandler tsy_TiposDeComprobantesCategoriaIvaRowDeleting;
            
            public void Addtsy_TiposDeComprobantesCategoriaIvaRow(tsy_TiposDeComprobantesCategoriaIvaRow row) {
                this.Rows.Add(row);
            }
            
            public tsy_TiposDeComprobantesCategoriaIvaRow Addtsy_TiposDeComprobantesCategoriaIvaRow(string IdTipoDeComprobante, string IdCategoriaIva, bool Activo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal) {
                tsy_TiposDeComprobantesCategoriaIvaRow rowtsy_TiposDeComprobantesCategoriaIvaRow = ((tsy_TiposDeComprobantesCategoriaIvaRow)(this.NewRow()));
                rowtsy_TiposDeComprobantesCategoriaIvaRow.ItemArray = new object[] {
                        IdTipoDeComprobante,
                        IdCategoriaIva,
                        Activo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtsy_TiposDeComprobantesCategoriaIvaRow);
                return rowtsy_TiposDeComprobantesCategoriaIvaRow;
            }
            
            public tsy_TiposDeComprobantesCategoriaIvaRow FindByIdTipoDeComprobanteIdCategoriaIva(string IdTipoDeComprobante, string IdCategoriaIva) {
                return ((tsy_TiposDeComprobantesCategoriaIvaRow)(this.Rows.Find(new object[] {
                            IdTipoDeComprobante,
                            IdCategoriaIva})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsy_TiposDeComprobantesCategoriaIvaDataTable cln = ((tsy_TiposDeComprobantesCategoriaIvaDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsy_TiposDeComprobantesCategoriaIvaDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTipoDeComprobante = this.Columns["IdTipoDeComprobante"];
                this.columnIdCategoriaIva = this.Columns["IdCategoriaIva"];
                this.columnActivo = this.Columns["Activo"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
            }
            
            private void InitClass() {
                this.columnIdTipoDeComprobante = new DataColumn("IdTipoDeComprobante", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoDeComprobante);
                this.columnIdCategoriaIva = new DataColumn("IdCategoriaIva", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdCategoriaIva);
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
                this.columnIdReservado = new DataColumn("IdReservado", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdReservado);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.Constraints.Add(new UniqueConstraint("tsy_TiposDeComprobantesCategoriaIvaKey1", new DataColumn[] {
                                this.columnIdTipoDeComprobante,
                                this.columnIdCategoriaIva}, true));
                this.columnIdTipoDeComprobante.AllowDBNull = false;
                this.columnIdCategoriaIva.AllowDBNull = false;
                this.columnActivo.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsy_TiposDeComprobantesCategoriaIvaRow Newtsy_TiposDeComprobantesCategoriaIvaRow() {
                return ((tsy_TiposDeComprobantesCategoriaIvaRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsy_TiposDeComprobantesCategoriaIvaRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsy_TiposDeComprobantesCategoriaIvaRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsy_TiposDeComprobantesCategoriaIvaRowChanged != null)) {
                    this.tsy_TiposDeComprobantesCategoriaIvaRowChanged(this, new tsy_TiposDeComprobantesCategoriaIvaRowChangeEvent(((tsy_TiposDeComprobantesCategoriaIvaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsy_TiposDeComprobantesCategoriaIvaRowChanging != null)) {
                    this.tsy_TiposDeComprobantesCategoriaIvaRowChanging(this, new tsy_TiposDeComprobantesCategoriaIvaRowChangeEvent(((tsy_TiposDeComprobantesCategoriaIvaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsy_TiposDeComprobantesCategoriaIvaRowDeleted != null)) {
                    this.tsy_TiposDeComprobantesCategoriaIvaRowDeleted(this, new tsy_TiposDeComprobantesCategoriaIvaRowChangeEvent(((tsy_TiposDeComprobantesCategoriaIvaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsy_TiposDeComprobantesCategoriaIvaRowDeleting != null)) {
                    this.tsy_TiposDeComprobantesCategoriaIvaRowDeleting(this, new tsy_TiposDeComprobantesCategoriaIvaRowChangeEvent(((tsy_TiposDeComprobantesCategoriaIvaRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsy_TiposDeComprobantesCategoriaIvaRow(tsy_TiposDeComprobantesCategoriaIvaRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_TiposDeComprobantesCategoriaIvaRow : DataRow {
            
            private tsy_TiposDeComprobantesCategoriaIvaDataTable tabletsy_TiposDeComprobantesCategoriaIva;
            
            internal tsy_TiposDeComprobantesCategoriaIvaRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsy_TiposDeComprobantesCategoriaIva = ((tsy_TiposDeComprobantesCategoriaIvaDataTable)(this.Table));
            }
            
            public string IdTipoDeComprobante {
                get {
                    return ((string)(this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdTipoDeComprobanteColumn]));
                }
                set {
                    this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdTipoDeComprobanteColumn] = value;
                }
            }
            
            public string IdCategoriaIva {
                get {
                    return ((string)(this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdCategoriaIvaColumn]));
                }
                set {
                    this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdCategoriaIvaColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    return ((bool)(this[this.tabletsy_TiposDeComprobantesCategoriaIva.ActivoColumn]));
                }
                set {
                    this[this.tabletsy_TiposDeComprobantesCategoriaIva.ActivoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsy_TiposDeComprobantesCategoriaIva.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposDeComprobantesCategoriaIva.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsy_TiposDeComprobantesCategoriaIva.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposDeComprobantesCategoriaIva.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsy_TiposDeComprobantesCategoriaIva.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposDeComprobantesCategoriaIva.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdSucursalColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsy_TiposDeComprobantesCategoriaIva.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsy_TiposDeComprobantesCategoriaIva.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsy_TiposDeComprobantesCategoriaIva.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_TiposDeComprobantesCategoriaIva.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsy_TiposDeComprobantesCategoriaIva.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_TiposDeComprobantesCategoriaIva.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsy_TiposDeComprobantesCategoriaIva.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsy_TiposDeComprobantesCategoriaIva.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsy_TiposDeComprobantesCategoriaIva.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsy_TiposDeComprobantesCategoriaIva.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsy_TiposDeComprobantesCategoriaIva.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsy_TiposDeComprobantesCategoriaIva.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_TiposDeComprobantesCategoriaIvaRowChangeEvent : EventArgs {
            
            private tsy_TiposDeComprobantesCategoriaIvaRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsy_TiposDeComprobantesCategoriaIvaRowChangeEvent(tsy_TiposDeComprobantesCategoriaIvaRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsy_TiposDeComprobantesCategoriaIvaRow Row {
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
