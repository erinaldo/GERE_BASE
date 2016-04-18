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
    public class tpu_ProveedoresEstadosDataset : DataSet {
        
        private tpu_ProveedoresEstadosDataTable tabletpu_ProveedoresEstados;
        
        public tpu_ProveedoresEstadosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tpu_ProveedoresEstadosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tpu_ProveedoresEstados"] != null)) {
                    this.Tables.Add(new tpu_ProveedoresEstadosDataTable(ds.Tables["tpu_ProveedoresEstados"]));
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
        public tpu_ProveedoresEstadosDataTable tpu_ProveedoresEstados {
            get {
                return this.tabletpu_ProveedoresEstados;
            }
        }
        
        public override DataSet Clone() {
            tpu_ProveedoresEstadosDataset cln = ((tpu_ProveedoresEstadosDataset)(base.Clone()));
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
            if ((ds.Tables["tpu_ProveedoresEstados"] != null)) {
                this.Tables.Add(new tpu_ProveedoresEstadosDataTable(ds.Tables["tpu_ProveedoresEstados"]));
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
            this.tabletpu_ProveedoresEstados = ((tpu_ProveedoresEstadosDataTable)(this.Tables["tpu_ProveedoresEstados"]));
            if ((this.tabletpu_ProveedoresEstados != null)) {
                this.tabletpu_ProveedoresEstados.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tpu_ProveedoresEstadosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tpu_ProveedoresEstados.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletpu_ProveedoresEstados = new tpu_ProveedoresEstadosDataTable();
            this.Tables.Add(this.tabletpu_ProveedoresEstados);
        }
        
        private bool ShouldSerializetpu_ProveedoresEstados() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tpu_ProveedoresEstadosRowChangeEventHandler(object sender, tpu_ProveedoresEstadosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_ProveedoresEstadosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdEstado;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnClave;
            
            private DataColumn columnObservaciones;
            
            private DataColumn columnActivo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSsucursal;
            
            internal tpu_ProveedoresEstadosDataTable() : 
                    base("tpu_ProveedoresEstados") {
                this.InitClass();
            }
            
            internal tpu_ProveedoresEstadosDataTable(DataTable table) : 
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
            
            internal DataColumn IdEstadoColumn {
                get {
                    return this.columnIdEstado;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn ClaveColumn {
                get {
                    return this.columnClave;
                }
            }
            
            internal DataColumn ObservacionesColumn {
                get {
                    return this.columnObservaciones;
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
            
            internal DataColumn IdSsucursalColumn {
                get {
                    return this.columnIdSsucursal;
                }
            }
            
            public tpu_ProveedoresEstadosRow this[int index] {
                get {
                    return ((tpu_ProveedoresEstadosRow)(this.Rows[index]));
                }
            }
            
            public event tpu_ProveedoresEstadosRowChangeEventHandler tpu_ProveedoresEstadosRowChanged;
            
            public event tpu_ProveedoresEstadosRowChangeEventHandler tpu_ProveedoresEstadosRowChanging;
            
            public event tpu_ProveedoresEstadosRowChangeEventHandler tpu_ProveedoresEstadosRowDeleted;
            
            public event tpu_ProveedoresEstadosRowChangeEventHandler tpu_ProveedoresEstadosRowDeleting;
            
            public void Addtpu_ProveedoresEstadosRow(tpu_ProveedoresEstadosRow row) {
                this.Rows.Add(row);
            }
            
            public tpu_ProveedoresEstadosRow Addtpu_ProveedoresEstadosRow(long IdEstado, string Descripcion, string Clave, string Observaciones, bool Activo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSsucursal) {
                tpu_ProveedoresEstadosRow rowtpu_ProveedoresEstadosRow = ((tpu_ProveedoresEstadosRow)(this.NewRow()));
                rowtpu_ProveedoresEstadosRow.ItemArray = new object[] {
                        IdEstado,
                        Descripcion,
                        Clave,
                        Observaciones,
                        Activo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSsucursal};
                this.Rows.Add(rowtpu_ProveedoresEstadosRow);
                return rowtpu_ProveedoresEstadosRow;
            }
            
            public tpu_ProveedoresEstadosRow FindByIdEstado(long IdEstado) {
                return ((tpu_ProveedoresEstadosRow)(this.Rows.Find(new object[] {
                            IdEstado})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tpu_ProveedoresEstadosDataTable cln = ((tpu_ProveedoresEstadosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tpu_ProveedoresEstadosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdEstado = this.Columns["IdEstado"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnClave = this.Columns["Clave"];
                this.columnObservaciones = this.Columns["Observaciones"];
                this.columnActivo = this.Columns["Activo"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSsucursal = this.Columns["IdSsucursal"];
            }
            
            private void InitClass() {
                this.columnIdEstado = new DataColumn("IdEstado", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEstado);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnClave = new DataColumn("Clave", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnClave);
                this.columnObservaciones = new DataColumn("Observaciones", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnObservaciones);
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
                this.columnIdSsucursal = new DataColumn("IdSsucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSsucursal);
                this.Constraints.Add(new UniqueConstraint("tpu_ProveedoresEstadosDatasetKey1", new DataColumn[] {
                                this.columnIdEstado}, true));
                this.columnIdEstado.AllowDBNull = false;
                this.columnIdEstado.Unique = true;
                this.columnActivo.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tpu_ProveedoresEstadosRow Newtpu_ProveedoresEstadosRow() {
                return ((tpu_ProveedoresEstadosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tpu_ProveedoresEstadosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tpu_ProveedoresEstadosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tpu_ProveedoresEstadosRowChanged != null)) {
                    this.tpu_ProveedoresEstadosRowChanged(this, new tpu_ProveedoresEstadosRowChangeEvent(((tpu_ProveedoresEstadosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tpu_ProveedoresEstadosRowChanging != null)) {
                    this.tpu_ProveedoresEstadosRowChanging(this, new tpu_ProveedoresEstadosRowChangeEvent(((tpu_ProveedoresEstadosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tpu_ProveedoresEstadosRowDeleted != null)) {
                    this.tpu_ProveedoresEstadosRowDeleted(this, new tpu_ProveedoresEstadosRowChangeEvent(((tpu_ProveedoresEstadosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tpu_ProveedoresEstadosRowDeleting != null)) {
                    this.tpu_ProveedoresEstadosRowDeleting(this, new tpu_ProveedoresEstadosRowChangeEvent(((tpu_ProveedoresEstadosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetpu_ProveedoresEstadosRow(tpu_ProveedoresEstadosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_ProveedoresEstadosRow : DataRow {
            
            private tpu_ProveedoresEstadosDataTable tabletpu_ProveedoresEstados;
            
            internal tpu_ProveedoresEstadosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletpu_ProveedoresEstados = ((tpu_ProveedoresEstadosDataTable)(this.Table));
            }
            
            public long IdEstado {
                get {
                    return ((long)(this[this.tabletpu_ProveedoresEstados.IdEstadoColumn]));
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.IdEstadoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tabletpu_ProveedoresEstados.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.DescripcionColumn] = value;
                }
            }
            
            public string Clave {
                get {
                    try {
                        return ((string)(this[this.tabletpu_ProveedoresEstados.ClaveColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.ClaveColumn] = value;
                }
            }
            
            public string Observaciones {
                get {
                    try {
                        return ((string)(this[this.tabletpu_ProveedoresEstados.ObservacionesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.ObservacionesColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    return ((bool)(this[this.tabletpu_ProveedoresEstados.ActivoColumn]));
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.ActivoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletpu_ProveedoresEstados.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ProveedoresEstados.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletpu_ProveedoresEstados.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ProveedoresEstados.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ProveedoresEstados.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletpu_ProveedoresEstados.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ProveedoresEstados.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSsucursal {
                get {
                    try {
                        return ((long)(this[this.tabletpu_ProveedoresEstados.IdSsucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_ProveedoresEstados.IdSsucursalColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tabletpu_ProveedoresEstados.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tabletpu_ProveedoresEstados.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsClaveNull() {
                return this.IsNull(this.tabletpu_ProveedoresEstados.ClaveColumn);
            }
            
            public void SetClaveNull() {
                this[this.tabletpu_ProveedoresEstados.ClaveColumn] = System.Convert.DBNull;
            }
            
            public bool IsObservacionesNull() {
                return this.IsNull(this.tabletpu_ProveedoresEstados.ObservacionesColumn);
            }
            
            public void SetObservacionesNull() {
                this[this.tabletpu_ProveedoresEstados.ObservacionesColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletpu_ProveedoresEstados.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletpu_ProveedoresEstados.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletpu_ProveedoresEstados.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletpu_ProveedoresEstados.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletpu_ProveedoresEstados.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletpu_ProveedoresEstados.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletpu_ProveedoresEstados.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletpu_ProveedoresEstados.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletpu_ProveedoresEstados.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletpu_ProveedoresEstados.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletpu_ProveedoresEstados.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletpu_ProveedoresEstados.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletpu_ProveedoresEstados.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletpu_ProveedoresEstados.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSsucursalNull() {
                return this.IsNull(this.tabletpu_ProveedoresEstados.IdSsucursalColumn);
            }
            
            public void SetIdSsucursalNull() {
                this[this.tabletpu_ProveedoresEstados.IdSsucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_ProveedoresEstadosRowChangeEvent : EventArgs {
            
            private tpu_ProveedoresEstadosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tpu_ProveedoresEstadosRowChangeEvent(tpu_ProveedoresEstadosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tpu_ProveedoresEstadosRow Row {
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