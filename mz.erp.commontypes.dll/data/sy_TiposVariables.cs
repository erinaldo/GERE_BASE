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
    public class sy_TiposVariablesDataset : DataSet {
        
        private sy_TiposVariablesDataTable tablesy_TiposVariables;
        
        public sy_TiposVariablesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_TiposVariablesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_TiposVariables"] != null)) {
                    this.Tables.Add(new sy_TiposVariablesDataTable(ds.Tables["sy_TiposVariables"]));
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
        public sy_TiposVariablesDataTable sy_TiposVariables {
            get {
                return this.tablesy_TiposVariables;
            }
        }
        
        public override DataSet Clone() {
            sy_TiposVariablesDataset cln = ((sy_TiposVariablesDataset)(base.Clone()));
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
            if ((ds.Tables["sy_TiposVariables"] != null)) {
                this.Tables.Add(new sy_TiposVariablesDataTable(ds.Tables["sy_TiposVariables"]));
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
            this.tablesy_TiposVariables = ((sy_TiposVariablesDataTable)(this.Tables["sy_TiposVariables"]));
            if ((this.tablesy_TiposVariables != null)) {
                this.tablesy_TiposVariables.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_TiposVariablesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_TiposVariables.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_TiposVariables = new sy_TiposVariablesDataTable();
            this.Tables.Add(this.tablesy_TiposVariables);
        }
        
        private bool ShouldSerializesy_TiposVariables() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_TiposVariablesRowChangeEventHandler(object sender, sy_TiposVariablesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_TiposVariablesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTipoVariable;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal sy_TiposVariablesDataTable() : 
                    base("sy_TiposVariables") {
                this.InitClass();
            }
            
            internal sy_TiposVariablesDataTable(DataTable table) : 
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
            
            internal DataColumn IdTipoVariableColumn {
                get {
                    return this.columnIdTipoVariable;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
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
            
            public sy_TiposVariablesRow this[int index] {
                get {
                    return ((sy_TiposVariablesRow)(this.Rows[index]));
                }
            }
            
            public event sy_TiposVariablesRowChangeEventHandler sy_TiposVariablesRowChanged;
            
            public event sy_TiposVariablesRowChangeEventHandler sy_TiposVariablesRowChanging;
            
            public event sy_TiposVariablesRowChangeEventHandler sy_TiposVariablesRowDeleted;
            
            public event sy_TiposVariablesRowChangeEventHandler sy_TiposVariablesRowDeleting;
            
            public void Addsy_TiposVariablesRow(sy_TiposVariablesRow row) {
                this.Rows.Add(row);
            }
            
            public sy_TiposVariablesRow Addsy_TiposVariablesRow(string IdTipoVariable, string Descripcion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                sy_TiposVariablesRow rowsy_TiposVariablesRow = ((sy_TiposVariablesRow)(this.NewRow()));
                rowsy_TiposVariablesRow.ItemArray = new object[] {
                        IdTipoVariable,
                        Descripcion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowsy_TiposVariablesRow);
                return rowsy_TiposVariablesRow;
            }
            
            public sy_TiposVariablesRow FindByIdTipoVariable(string IdTipoVariable) {
                return ((sy_TiposVariablesRow)(this.Rows.Find(new object[] {
                            IdTipoVariable})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_TiposVariablesDataTable cln = ((sy_TiposVariablesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_TiposVariablesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTipoVariable = this.Columns["IdTipoVariable"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdTipoVariable = new DataColumn("IdTipoVariable", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoVariable);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
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
                this.Constraints.Add(new UniqueConstraint("sy_TiposVariablesDatasetKey1", new DataColumn[] {
                                this.columnIdTipoVariable}, true));
                this.columnIdTipoVariable.AllowDBNull = false;
                this.columnIdTipoVariable.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_TiposVariablesRow Newsy_TiposVariablesRow() {
                return ((sy_TiposVariablesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_TiposVariablesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_TiposVariablesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_TiposVariablesRowChanged != null)) {
                    this.sy_TiposVariablesRowChanged(this, new sy_TiposVariablesRowChangeEvent(((sy_TiposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_TiposVariablesRowChanging != null)) {
                    this.sy_TiposVariablesRowChanging(this, new sy_TiposVariablesRowChangeEvent(((sy_TiposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_TiposVariablesRowDeleted != null)) {
                    this.sy_TiposVariablesRowDeleted(this, new sy_TiposVariablesRowChangeEvent(((sy_TiposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_TiposVariablesRowDeleting != null)) {
                    this.sy_TiposVariablesRowDeleting(this, new sy_TiposVariablesRowChangeEvent(((sy_TiposVariablesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_TiposVariablesRow(sy_TiposVariablesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_TiposVariablesRow : DataRow {
            
            private sy_TiposVariablesDataTable tablesy_TiposVariables;
            
            internal sy_TiposVariablesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_TiposVariables = ((sy_TiposVariablesDataTable)(this.Table));
            }
            
            public string IdTipoVariable {
                get {
                    return ((string)(this[this.tablesy_TiposVariables.IdTipoVariableColumn]));
                }
                set {
                    this[this.tablesy_TiposVariables.IdTipoVariableColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tablesy_TiposVariables.DescripcionColumn]));
                }
                set {
                    this[this.tablesy_TiposVariables.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tablesy_TiposVariables.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_TiposVariables.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_TiposVariables.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_TiposVariables.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_TiposVariables.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_TiposVariables.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_TiposVariables.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_TiposVariables.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_TiposVariables.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_TiposVariables.RowIdColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tablesy_TiposVariables.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tablesy_TiposVariables.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tablesy_TiposVariables.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tablesy_TiposVariables.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_TiposVariables.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_TiposVariables.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_TiposVariables.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_TiposVariables.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_TiposVariables.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_TiposVariables.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_TiposVariablesRowChangeEvent : EventArgs {
            
            private sy_TiposVariablesRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_TiposVariablesRowChangeEvent(sy_TiposVariablesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_TiposVariablesRow Row {
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