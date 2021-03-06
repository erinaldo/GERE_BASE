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
    public class tsy_MotivosDiferenciasComprasDataset : DataSet {
        
        private tsy_MotivosDiferenciasComprasDataTable tabletsy_MotivosDiferenciasCompras;
        
        public tsy_MotivosDiferenciasComprasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsy_MotivosDiferenciasComprasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsy_MotivosDiferenciasCompras"] != null)) {
                    this.Tables.Add(new tsy_MotivosDiferenciasComprasDataTable(ds.Tables["tsy_MotivosDiferenciasCompras"]));
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
        public tsy_MotivosDiferenciasComprasDataTable tsy_MotivosDiferenciasCompras {
            get {
                return this.tabletsy_MotivosDiferenciasCompras;
            }
        }
        
        public override DataSet Clone() {
            tsy_MotivosDiferenciasComprasDataset cln = ((tsy_MotivosDiferenciasComprasDataset)(base.Clone()));
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
            if ((ds.Tables["tsy_MotivosDiferenciasCompras"] != null)) {
                this.Tables.Add(new tsy_MotivosDiferenciasComprasDataTable(ds.Tables["tsy_MotivosDiferenciasCompras"]));
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
            this.tabletsy_MotivosDiferenciasCompras = ((tsy_MotivosDiferenciasComprasDataTable)(this.Tables["tsy_MotivosDiferenciasCompras"]));
            if ((this.tabletsy_MotivosDiferenciasCompras != null)) {
                this.tabletsy_MotivosDiferenciasCompras.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsy_MotivosDiferenciasComprasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsy_MotivosDiferenciasCompras.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsy_MotivosDiferenciasCompras = new tsy_MotivosDiferenciasComprasDataTable();
            this.Tables.Add(this.tabletsy_MotivosDiferenciasCompras);
        }
        
        private bool ShouldSerializetsy_MotivosDiferenciasCompras() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsy_MotivosDiferenciasComprasRowChangeEventHandler(object sender, tsy_MotivosDiferenciasComprasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_MotivosDiferenciasComprasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdMotivoDiferencia;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnActivo;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tsy_MotivosDiferenciasComprasDataTable() : 
                    base("tsy_MotivosDiferenciasCompras") {
                this.InitClass();
            }
            
            internal tsy_MotivosDiferenciasComprasDataTable(DataTable table) : 
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
            
            internal DataColumn IdMotivoDiferenciaColumn {
                get {
                    return this.columnIdMotivoDiferencia;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn ActivoColumn {
                get {
                    return this.columnActivo;
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
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            public tsy_MotivosDiferenciasComprasRow this[int index] {
                get {
                    return ((tsy_MotivosDiferenciasComprasRow)(this.Rows[index]));
                }
            }
            
            public event tsy_MotivosDiferenciasComprasRowChangeEventHandler tsy_MotivosDiferenciasComprasRowChanged;
            
            public event tsy_MotivosDiferenciasComprasRowChangeEventHandler tsy_MotivosDiferenciasComprasRowChanging;
            
            public event tsy_MotivosDiferenciasComprasRowChangeEventHandler tsy_MotivosDiferenciasComprasRowDeleted;
            
            public event tsy_MotivosDiferenciasComprasRowChangeEventHandler tsy_MotivosDiferenciasComprasRowDeleting;
            
            public void Addtsy_MotivosDiferenciasComprasRow(tsy_MotivosDiferenciasComprasRow row) {
                this.Rows.Add(row);
            }
            
            public tsy_MotivosDiferenciasComprasRow Addtsy_MotivosDiferenciasComprasRow(string Descripcion, bool Activo, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa) {
                tsy_MotivosDiferenciasComprasRow rowtsy_MotivosDiferenciasComprasRow = ((tsy_MotivosDiferenciasComprasRow)(this.NewRow()));
                rowtsy_MotivosDiferenciasComprasRow.ItemArray = new object[] {
                        null,
                        Descripcion,
                        Activo,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtsy_MotivosDiferenciasComprasRow);
                return rowtsy_MotivosDiferenciasComprasRow;
            }
            
            public tsy_MotivosDiferenciasComprasRow FindByIdMotivoDiferencia(long IdMotivoDiferencia) {
                return ((tsy_MotivosDiferenciasComprasRow)(this.Rows.Find(new object[] {
                            IdMotivoDiferencia})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsy_MotivosDiferenciasComprasDataTable cln = ((tsy_MotivosDiferenciasComprasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsy_MotivosDiferenciasComprasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdMotivoDiferencia = this.Columns["IdMotivoDiferencia"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnActivo = this.Columns["Activo"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
            }
            
            private void InitClass() {
                this.columnIdMotivoDiferencia = new DataColumn("IdMotivoDiferencia", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdMotivoDiferencia);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnActivo = new DataColumn("Activo", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnActivo);
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
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.Constraints.Add(new UniqueConstraint("tsy_MotivosDiferenciasComprasKey1", new DataColumn[] {
                                this.columnIdMotivoDiferencia}, true));
                this.columnIdMotivoDiferencia.AutoIncrement = true;
                this.columnIdMotivoDiferencia.AllowDBNull = false;
                this.columnIdMotivoDiferencia.ReadOnly = true;
                this.columnIdMotivoDiferencia.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnActivo.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsy_MotivosDiferenciasComprasRow Newtsy_MotivosDiferenciasComprasRow() {
                return ((tsy_MotivosDiferenciasComprasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsy_MotivosDiferenciasComprasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsy_MotivosDiferenciasComprasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsy_MotivosDiferenciasComprasRowChanged != null)) {
                    this.tsy_MotivosDiferenciasComprasRowChanged(this, new tsy_MotivosDiferenciasComprasRowChangeEvent(((tsy_MotivosDiferenciasComprasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsy_MotivosDiferenciasComprasRowChanging != null)) {
                    this.tsy_MotivosDiferenciasComprasRowChanging(this, new tsy_MotivosDiferenciasComprasRowChangeEvent(((tsy_MotivosDiferenciasComprasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsy_MotivosDiferenciasComprasRowDeleted != null)) {
                    this.tsy_MotivosDiferenciasComprasRowDeleted(this, new tsy_MotivosDiferenciasComprasRowChangeEvent(((tsy_MotivosDiferenciasComprasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsy_MotivosDiferenciasComprasRowDeleting != null)) {
                    this.tsy_MotivosDiferenciasComprasRowDeleting(this, new tsy_MotivosDiferenciasComprasRowChangeEvent(((tsy_MotivosDiferenciasComprasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsy_MotivosDiferenciasComprasRow(tsy_MotivosDiferenciasComprasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_MotivosDiferenciasComprasRow : DataRow {
            
            private tsy_MotivosDiferenciasComprasDataTable tabletsy_MotivosDiferenciasCompras;
            
            internal tsy_MotivosDiferenciasComprasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsy_MotivosDiferenciasCompras = ((tsy_MotivosDiferenciasComprasDataTable)(this.Table));
            }
            
            public long IdMotivoDiferencia {
                get {
                    return ((long)(this[this.tabletsy_MotivosDiferenciasCompras.IdMotivoDiferenciaColumn]));
                }
                set {
                    this[this.tabletsy_MotivosDiferenciasCompras.IdMotivoDiferenciaColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tabletsy_MotivosDiferenciasCompras.DescripcionColumn]));
                }
                set {
                    this[this.tabletsy_MotivosDiferenciasCompras.DescripcionColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    return ((bool)(this[this.tabletsy_MotivosDiferenciasCompras.ActivoColumn]));
                }
                set {
                    this[this.tabletsy_MotivosDiferenciasCompras.ActivoColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsy_MotivosDiferenciasCompras.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivosDiferenciasCompras.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsy_MotivosDiferenciasCompras.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivosDiferenciasCompras.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsy_MotivosDiferenciasCompras.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivosDiferenciasCompras.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsy_MotivosDiferenciasCompras.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivosDiferenciasCompras.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsy_MotivosDiferenciasCompras.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivosDiferenciasCompras.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsy_MotivosDiferenciasCompras.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivosDiferenciasCompras.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsy_MotivosDiferenciasCompras.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_MotivosDiferenciasCompras.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsy_MotivosDiferenciasCompras.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsy_MotivosDiferenciasCompras.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_MotivosDiferenciasCompras.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsy_MotivosDiferenciasCompras.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsy_MotivosDiferenciasCompras.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsy_MotivosDiferenciasCompras.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsy_MotivosDiferenciasCompras.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsy_MotivosDiferenciasCompras.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsy_MotivosDiferenciasCompras.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsy_MotivosDiferenciasCompras.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsy_MotivosDiferenciasCompras.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsy_MotivosDiferenciasCompras.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsy_MotivosDiferenciasCompras.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsy_MotivosDiferenciasCompras.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_MotivosDiferenciasComprasRowChangeEvent : EventArgs {
            
            private tsy_MotivosDiferenciasComprasRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsy_MotivosDiferenciasComprasRowChangeEvent(tsy_MotivosDiferenciasComprasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsy_MotivosDiferenciasComprasRow Row {
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
