﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
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
    public class PerfilesExDataset : DataSet {
        
        private PerfilesDataTable tablePerfiles;
        
        public PerfilesExDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected PerfilesExDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Perfiles"] != null)) {
                    this.Tables.Add(new PerfilesDataTable(ds.Tables["Perfiles"]));
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
        public PerfilesDataTable Perfiles {
            get {
                return this.tablePerfiles;
            }
        }
        
        public override DataSet Clone() {
            PerfilesExDataset cln = ((PerfilesExDataset)(base.Clone()));
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
            if ((ds.Tables["Perfiles"] != null)) {
                this.Tables.Add(new PerfilesDataTable(ds.Tables["Perfiles"]));
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
            this.tablePerfiles = ((PerfilesDataTable)(this.Tables["Perfiles"]));
            if ((this.tablePerfiles != null)) {
                this.tablePerfiles.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "PerfilesExDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/PerfilesExDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablePerfiles = new PerfilesDataTable();
            this.Tables.Add(this.tablePerfiles);
        }
        
        private bool ShouldSerializePerfiles() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void PerfilesRowChangeEventHandler(object sender, PerfilesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class PerfilesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdPerfil;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnActivo;
            
            private DataColumn columnComentario;
            
            private DataColumn columnIdConexion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal PerfilesDataTable() : 
                    base("Perfiles") {
                this.InitClass();
            }
            
            internal PerfilesDataTable(DataTable table) : 
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
            
            internal DataColumn IdPerfilColumn {
                get {
                    return this.columnIdPerfil;
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
            
            internal DataColumn ComentarioColumn {
                get {
                    return this.columnComentario;
                }
            }
            
            internal DataColumn IdConexionColumn {
                get {
                    return this.columnIdConexion;
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
            
            public PerfilesRow this[int index] {
                get {
                    return ((PerfilesRow)(this.Rows[index]));
                }
            }
            
            public event PerfilesRowChangeEventHandler PerfilesRowChanged;
            
            public event PerfilesRowChangeEventHandler PerfilesRowChanging;
            
            public event PerfilesRowChangeEventHandler PerfilesRowDeleted;
            
            public event PerfilesRowChangeEventHandler PerfilesRowDeleting;
            
            public void AddPerfilesRow(PerfilesRow row) {
                this.Rows.Add(row);
            }
            
            public PerfilesRow AddPerfilesRow(long IdPerfil, string Descripcion, bool Activo, string Comentario, long IdConexion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                PerfilesRow rowPerfilesRow = ((PerfilesRow)(this.NewRow()));
                rowPerfilesRow.ItemArray = new object[] {
                        IdPerfil,
                        Descripcion,
                        Activo,
                        Comentario,
                        IdConexion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowPerfilesRow);
                return rowPerfilesRow;
            }
            
            public PerfilesRow FindByIdPerfil(long IdPerfil) {
                return ((PerfilesRow)(this.Rows.Find(new object[] {
                            IdPerfil})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                PerfilesDataTable cln = ((PerfilesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new PerfilesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdPerfil = this.Columns["IdPerfil"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnActivo = this.Columns["Activo"];
                this.columnComentario = this.Columns["Comentario"];
                this.columnIdConexion = this.Columns["IdConexion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdPerfil = new DataColumn("IdPerfil", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPerfil);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnActivo = new DataColumn("Activo", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnActivo);
                this.columnComentario = new DataColumn("Comentario", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnComentario);
                this.columnIdConexion = new DataColumn("IdConexion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexion);
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
                this.Constraints.Add(new UniqueConstraint("PerfilesExDatasetKey1", new DataColumn[] {
                                this.columnIdPerfil}, true));
                this.columnIdPerfil.AllowDBNull = false;
                this.columnIdPerfil.Unique = true;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public PerfilesRow NewPerfilesRow() {
                return ((PerfilesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new PerfilesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(PerfilesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.PerfilesRowChanged != null)) {
                    this.PerfilesRowChanged(this, new PerfilesRowChangeEvent(((PerfilesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.PerfilesRowChanging != null)) {
                    this.PerfilesRowChanging(this, new PerfilesRowChangeEvent(((PerfilesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.PerfilesRowDeleted != null)) {
                    this.PerfilesRowDeleted(this, new PerfilesRowChangeEvent(((PerfilesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.PerfilesRowDeleting != null)) {
                    this.PerfilesRowDeleting(this, new PerfilesRowChangeEvent(((PerfilesRow)(e.Row)), e.Action));
                }
            }
            
            public void RemovePerfilesRow(PerfilesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class PerfilesRow : DataRow {
            
            private PerfilesDataTable tablePerfiles;
            
            internal PerfilesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablePerfiles = ((PerfilesDataTable)(this.Table));
            }
            
            public long IdPerfil {
                get {
                    return ((long)(this[this.tablePerfiles.IdPerfilColumn]));
                }
                set {
                    this[this.tablePerfiles.IdPerfilColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tablePerfiles.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablePerfiles.DescripcionColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    try {
                        return ((bool)(this[this.tablePerfiles.ActivoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablePerfiles.ActivoColumn] = value;
                }
            }
            
            public string Comentario {
                get {
                    try {
                        return ((string)(this[this.tablePerfiles.ComentarioColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablePerfiles.ComentarioColumn] = value;
                }
            }
            
            public long IdConexion {
                get {
                    try {
                        return ((long)(this[this.tablePerfiles.IdConexionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablePerfiles.IdConexionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tablePerfiles.FechaCreacionColumn]));
                }
                set {
                    this[this.tablePerfiles.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablePerfiles.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablePerfiles.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablePerfiles.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablePerfiles.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablePerfiles.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablePerfiles.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablePerfiles.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablePerfiles.RowIdColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tablePerfiles.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tablePerfiles.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsActivoNull() {
                return this.IsNull(this.tablePerfiles.ActivoColumn);
            }
            
            public void SetActivoNull() {
                this[this.tablePerfiles.ActivoColumn] = System.Convert.DBNull;
            }
            
            public bool IsComentarioNull() {
                return this.IsNull(this.tablePerfiles.ComentarioColumn);
            }
            
            public void SetComentarioNull() {
                this[this.tablePerfiles.ComentarioColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionNull() {
                return this.IsNull(this.tablePerfiles.IdConexionColumn);
            }
            
            public void SetIdConexionNull() {
                this[this.tablePerfiles.IdConexionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablePerfiles.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablePerfiles.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablePerfiles.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablePerfiles.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablePerfiles.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablePerfiles.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class PerfilesRowChangeEvent : EventArgs {
            
            private PerfilesRow eventRow;
            
            private DataRowAction eventAction;
            
            public PerfilesRowChangeEvent(PerfilesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public PerfilesRow Row {
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