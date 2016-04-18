﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
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
    public class tsh_AutorizacionesDataset : DataSet {
        
        private tsh_AutorizacionesDataTable tabletsh_Autorizaciones;
        
        public tsh_AutorizacionesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsh_AutorizacionesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsh_Autorizaciones"] != null)) {
                    this.Tables.Add(new tsh_AutorizacionesDataTable(ds.Tables["tsh_Autorizaciones"]));
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
        public tsh_AutorizacionesDataTable tsh_Autorizaciones {
            get {
                return this.tabletsh_Autorizaciones;
            }
        }
        
        public override DataSet Clone() {
            tsh_AutorizacionesDataset cln = ((tsh_AutorizacionesDataset)(base.Clone()));
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
            if ((ds.Tables["tsh_Autorizaciones"] != null)) {
                this.Tables.Add(new tsh_AutorizacionesDataTable(ds.Tables["tsh_Autorizaciones"]));
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
            this.tabletsh_Autorizaciones = ((tsh_AutorizacionesDataTable)(this.Tables["tsh_Autorizaciones"]));
            if ((this.tabletsh_Autorizaciones != null)) {
                this.tabletsh_Autorizaciones.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsh_AutorizacionesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsh_Autorizaciones.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsh_Autorizaciones = new tsh_AutorizacionesDataTable();
            this.Tables.Add(this.tabletsh_Autorizaciones);
        }
        
        private bool ShouldSerializetsh_Autorizaciones() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsh_AutorizacionesRowChangeEventHandler(object sender, tsh_AutorizacionesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_AutorizacionesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdAutorizacion;
            
            private DataColumn columnIdResponsable;
            
            private DataColumn columnMotivo;
            
            private DataColumn columnDatos;
            
            private DataColumn columnDatosBinarios;
            
            private DataColumn columnTipoDatosBinarios;
            
            private DataColumn columnEstado;
            
            private DataColumn columnIdResponsableDeAutorizacion;
            
            private DataColumn columnObservaciones;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tsh_AutorizacionesDataTable() : 
                    base("tsh_Autorizaciones") {
                this.InitClass();
            }
            
            internal tsh_AutorizacionesDataTable(DataTable table) : 
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
            
            internal DataColumn IdAutorizacionColumn {
                get {
                    return this.columnIdAutorizacion;
                }
            }
            
            internal DataColumn IdResponsableColumn {
                get {
                    return this.columnIdResponsable;
                }
            }
            
            internal DataColumn MotivoColumn {
                get {
                    return this.columnMotivo;
                }
            }
            
            internal DataColumn DatosColumn {
                get {
                    return this.columnDatos;
                }
            }
            
            internal DataColumn DatosBinariosColumn {
                get {
                    return this.columnDatosBinarios;
                }
            }
            
            internal DataColumn TipoDatosBinariosColumn {
                get {
                    return this.columnTipoDatosBinarios;
                }
            }
            
            internal DataColumn EstadoColumn {
                get {
                    return this.columnEstado;
                }
            }
            
            internal DataColumn IdResponsableDeAutorizacionColumn {
                get {
                    return this.columnIdResponsableDeAutorizacion;
                }
            }
            
            internal DataColumn ObservacionesColumn {
                get {
                    return this.columnObservaciones;
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
            
            public tsh_AutorizacionesRow this[int index] {
                get {
                    return ((tsh_AutorizacionesRow)(this.Rows[index]));
                }
            }
            
            public event tsh_AutorizacionesRowChangeEventHandler tsh_AutorizacionesRowChanged;
            
            public event tsh_AutorizacionesRowChangeEventHandler tsh_AutorizacionesRowChanging;
            
            public event tsh_AutorizacionesRowChangeEventHandler tsh_AutorizacionesRowDeleted;
            
            public event tsh_AutorizacionesRowChangeEventHandler tsh_AutorizacionesRowDeleting;
            
            public void Addtsh_AutorizacionesRow(tsh_AutorizacionesRow row) {
                this.Rows.Add(row);
            }
            
            public tsh_AutorizacionesRow Addtsh_AutorizacionesRow(
                        string IdAutorizacion, 
                        string IdResponsable, 
                        string Motivo, 
                        string Datos, 
                        System.Byte[] DatosBinarios, 
                        string TipoDatosBinarios, 
                        string Estado, 
                        string IdResponsableDeAutorizacion, 
                        string Observaciones, 
                        System.DateTime FechaCreacion, 
                        long IdConexionCreacion, 
                        System.Byte[] UltimaModificacion, 
                        long IdConexionUltimaModificacion, 
                        long IdReservado, 
                        System.Guid RowId, 
                        long IdSucursal, 
                        long IdEmpresa) {
                tsh_AutorizacionesRow rowtsh_AutorizacionesRow = ((tsh_AutorizacionesRow)(this.NewRow()));
                rowtsh_AutorizacionesRow.ItemArray = new object[] {
                        IdAutorizacion,
                        IdResponsable,
                        Motivo,
                        Datos,
                        DatosBinarios,
                        TipoDatosBinarios,
                        Estado,
                        IdResponsableDeAutorizacion,
                        Observaciones,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtsh_AutorizacionesRow);
                return rowtsh_AutorizacionesRow;
            }
            
            public tsh_AutorizacionesRow FindByIdAutorizacion(string IdAutorizacion) {
                return ((tsh_AutorizacionesRow)(this.Rows.Find(new object[] {
                            IdAutorizacion})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsh_AutorizacionesDataTable cln = ((tsh_AutorizacionesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsh_AutorizacionesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdAutorizacion = this.Columns["IdAutorizacion"];
                this.columnIdResponsable = this.Columns["IdResponsable"];
                this.columnMotivo = this.Columns["Motivo"];
                this.columnDatos = this.Columns["Datos"];
                this.columnDatosBinarios = this.Columns["DatosBinarios"];
                this.columnTipoDatosBinarios = this.Columns["TipoDatosBinarios"];
                this.columnEstado = this.Columns["Estado"];
                this.columnIdResponsableDeAutorizacion = this.Columns["IdResponsableDeAutorizacion"];
                this.columnObservaciones = this.Columns["Observaciones"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
            }
            
            private void InitClass() {
                this.columnIdAutorizacion = new DataColumn("IdAutorizacion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdAutorizacion);
                this.columnIdResponsable = new DataColumn("IdResponsable", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdResponsable);
                this.columnMotivo = new DataColumn("Motivo", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnMotivo);
                this.columnDatos = new DataColumn("Datos", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDatos);
                this.columnDatosBinarios = new DataColumn("DatosBinarios", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDatosBinarios);
                this.columnTipoDatosBinarios = new DataColumn("TipoDatosBinarios", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTipoDatosBinarios);
                this.columnEstado = new DataColumn("Estado", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEstado);
                this.columnIdResponsableDeAutorizacion = new DataColumn("IdResponsableDeAutorizacion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdResponsableDeAutorizacion);
                this.columnObservaciones = new DataColumn("Observaciones", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnObservaciones);
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
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.Constraints.Add(new UniqueConstraint("tsh_AutorizacionesDatasetKey1", new DataColumn[] {
                                this.columnIdAutorizacion}, true));
                this.columnIdAutorizacion.AllowDBNull = false;
                this.columnIdAutorizacion.Unique = true;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsh_AutorizacionesRow Newtsh_AutorizacionesRow() {
                return ((tsh_AutorizacionesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsh_AutorizacionesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsh_AutorizacionesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsh_AutorizacionesRowChanged != null)) {
                    this.tsh_AutorizacionesRowChanged(this, new tsh_AutorizacionesRowChangeEvent(((tsh_AutorizacionesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsh_AutorizacionesRowChanging != null)) {
                    this.tsh_AutorizacionesRowChanging(this, new tsh_AutorizacionesRowChangeEvent(((tsh_AutorizacionesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsh_AutorizacionesRowDeleted != null)) {
                    this.tsh_AutorizacionesRowDeleted(this, new tsh_AutorizacionesRowChangeEvent(((tsh_AutorizacionesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsh_AutorizacionesRowDeleting != null)) {
                    this.tsh_AutorizacionesRowDeleting(this, new tsh_AutorizacionesRowChangeEvent(((tsh_AutorizacionesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsh_AutorizacionesRow(tsh_AutorizacionesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_AutorizacionesRow : DataRow {
            
            private tsh_AutorizacionesDataTable tabletsh_Autorizaciones;
            
            internal tsh_AutorizacionesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsh_Autorizaciones = ((tsh_AutorizacionesDataTable)(this.Table));
            }
            
            public string IdAutorizacion {
                get {
                    return ((string)(this[this.tabletsh_Autorizaciones.IdAutorizacionColumn]));
                }
                set {
                    this[this.tabletsh_Autorizaciones.IdAutorizacionColumn] = value;
                }
            }
            
            public string IdResponsable {
                get {
                    try {
                        return ((string)(this[this.tabletsh_Autorizaciones.IdResponsableColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.IdResponsableColumn] = value;
                }
            }
            
            public string Motivo {
                get {
                    try {
                        return ((string)(this[this.tabletsh_Autorizaciones.MotivoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.MotivoColumn] = value;
                }
            }
            
            public string Datos {
                get {
                    try {
                        return ((string)(this[this.tabletsh_Autorizaciones.DatosColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.DatosColumn] = value;
                }
            }
            
            public System.Byte[] DatosBinarios {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsh_Autorizaciones.DatosBinariosColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.DatosBinariosColumn] = value;
                }
            }
            
            public string TipoDatosBinarios {
                get {
                    try {
                        return ((string)(this[this.tabletsh_Autorizaciones.TipoDatosBinariosColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.TipoDatosBinariosColumn] = value;
                }
            }
            
            public string Estado {
                get {
                    try {
                        return ((string)(this[this.tabletsh_Autorizaciones.EstadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.EstadoColumn] = value;
                }
            }
            
            public string IdResponsableDeAutorizacion {
                get {
                    try {
                        return ((string)(this[this.tabletsh_Autorizaciones.IdResponsableDeAutorizacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.IdResponsableDeAutorizacionColumn] = value;
                }
            }
            
            public string Observaciones {
                get {
                    try {
                        return ((string)(this[this.tabletsh_Autorizaciones.ObservacionesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.ObservacionesColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsh_Autorizaciones.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Autorizaciones.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsh_Autorizaciones.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Autorizaciones.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Autorizaciones.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsh_Autorizaciones.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Autorizaciones.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Autorizaciones.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Autorizaciones.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsIdResponsableNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.IdResponsableColumn);
            }
            
            public void SetIdResponsableNull() {
                this[this.tabletsh_Autorizaciones.IdResponsableColumn] = System.Convert.DBNull;
            }
            
            public bool IsMotivoNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.MotivoColumn);
            }
            
            public void SetMotivoNull() {
                this[this.tabletsh_Autorizaciones.MotivoColumn] = System.Convert.DBNull;
            }
            
            public bool IsDatosNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.DatosColumn);
            }
            
            public void SetDatosNull() {
                this[this.tabletsh_Autorizaciones.DatosColumn] = System.Convert.DBNull;
            }
            
            public bool IsDatosBinariosNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.DatosBinariosColumn);
            }
            
            public void SetDatosBinariosNull() {
                this[this.tabletsh_Autorizaciones.DatosBinariosColumn] = System.Convert.DBNull;
            }
            
            public bool IsTipoDatosBinariosNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.TipoDatosBinariosColumn);
            }
            
            public void SetTipoDatosBinariosNull() {
                this[this.tabletsh_Autorizaciones.TipoDatosBinariosColumn] = System.Convert.DBNull;
            }
            
            public bool IsEstadoNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.EstadoColumn);
            }
            
            public void SetEstadoNull() {
                this[this.tabletsh_Autorizaciones.EstadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdResponsableDeAutorizacionNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.IdResponsableDeAutorizacionColumn);
            }
            
            public void SetIdResponsableDeAutorizacionNull() {
                this[this.tabletsh_Autorizaciones.IdResponsableDeAutorizacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsObservacionesNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.ObservacionesColumn);
            }
            
            public void SetObservacionesNull() {
                this[this.tabletsh_Autorizaciones.ObservacionesColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsh_Autorizaciones.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsh_Autorizaciones.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsh_Autorizaciones.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsh_Autorizaciones.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsh_Autorizaciones.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsh_Autorizaciones.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsh_Autorizaciones.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsh_Autorizaciones.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsh_Autorizaciones.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_AutorizacionesRowChangeEvent : EventArgs {
            
            private tsh_AutorizacionesRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsh_AutorizacionesRowChangeEvent(tsh_AutorizacionesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsh_AutorizacionesRow Row {
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