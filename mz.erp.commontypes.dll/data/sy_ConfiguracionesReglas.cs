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
    public class sy_ConfiguracionesReglasDataset : DataSet {
        
        private sy_ConfiguracionesReglasDataTable tablesy_ConfiguracionesReglas;
        
        public sy_ConfiguracionesReglasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_ConfiguracionesReglasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_ConfiguracionesReglas"] != null)) {
                    this.Tables.Add(new sy_ConfiguracionesReglasDataTable(ds.Tables["sy_ConfiguracionesReglas"]));
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
        public sy_ConfiguracionesReglasDataTable sy_ConfiguracionesReglas {
            get {
                return this.tablesy_ConfiguracionesReglas;
            }
        }
        
        public override DataSet Clone() {
            sy_ConfiguracionesReglasDataset cln = ((sy_ConfiguracionesReglasDataset)(base.Clone()));
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
            if ((ds.Tables["sy_ConfiguracionesReglas"] != null)) {
                this.Tables.Add(new sy_ConfiguracionesReglasDataTable(ds.Tables["sy_ConfiguracionesReglas"]));
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
            this.tablesy_ConfiguracionesReglas = ((sy_ConfiguracionesReglasDataTable)(this.Tables["sy_ConfiguracionesReglas"]));
            if ((this.tablesy_ConfiguracionesReglas != null)) {
                this.tablesy_ConfiguracionesReglas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_ConfiguracionesReglasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_ConfiguracionesReglas.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_ConfiguracionesReglas = new sy_ConfiguracionesReglasDataTable();
            this.Tables.Add(this.tablesy_ConfiguracionesReglas);
        }
        
        private bool ShouldSerializesy_ConfiguracionesReglas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_ConfiguracionesReglasRowChangeEventHandler(object sender, sy_ConfiguracionesReglasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_ConfiguracionesReglasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdConfiguracion;
            
            private DataColumn columnnombre;
            
            private DataColumn columnValorDefault;
            
            private DataColumn columnValor;
            
            private DataColumn columnIdRegla;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            private DataColumn columnDescripcion;
            
            internal sy_ConfiguracionesReglasDataTable() : 
                    base("sy_ConfiguracionesReglas") {
                this.InitClass();
            }
            
            internal sy_ConfiguracionesReglasDataTable(DataTable table) : 
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
            
            internal DataColumn IdConfiguracionColumn {
                get {
                    return this.columnIdConfiguracion;
                }
            }
            
            internal DataColumn nombreColumn {
                get {
                    return this.columnnombre;
                }
            }
            
            internal DataColumn ValorDefaultColumn {
                get {
                    return this.columnValorDefault;
                }
            }
            
            internal DataColumn ValorColumn {
                get {
                    return this.columnValor;
                }
            }
            
            internal DataColumn IdReglaColumn {
                get {
                    return this.columnIdRegla;
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
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            public sy_ConfiguracionesReglasRow this[int index] {
                get {
                    return ((sy_ConfiguracionesReglasRow)(this.Rows[index]));
                }
            }
            
            public event sy_ConfiguracionesReglasRowChangeEventHandler sy_ConfiguracionesReglasRowChanged;
            
            public event sy_ConfiguracionesReglasRowChangeEventHandler sy_ConfiguracionesReglasRowChanging;
            
            public event sy_ConfiguracionesReglasRowChangeEventHandler sy_ConfiguracionesReglasRowDeleted;
            
            public event sy_ConfiguracionesReglasRowChangeEventHandler sy_ConfiguracionesReglasRowDeleting;
            
            public void Addsy_ConfiguracionesReglasRow(sy_ConfiguracionesReglasRow row) {
                this.Rows.Add(row);
            }
            
            public sy_ConfiguracionesReglasRow Addsy_ConfiguracionesReglasRow(string IdConfiguracion, string nombre, string ValorDefault, string Valor, string IdRegla, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId, string Descripcion) {
                sy_ConfiguracionesReglasRow rowsy_ConfiguracionesReglasRow = ((sy_ConfiguracionesReglasRow)(this.NewRow()));
                rowsy_ConfiguracionesReglasRow.ItemArray = new object[] {
                        IdConfiguracion,
                        nombre,
                        ValorDefault,
                        Valor,
                        IdRegla,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId,
                        Descripcion};
                this.Rows.Add(rowsy_ConfiguracionesReglasRow);
                return rowsy_ConfiguracionesReglasRow;
            }
            
            public sy_ConfiguracionesReglasRow FindByIdConfiguracion(string IdConfiguracion) {
                return ((sy_ConfiguracionesReglasRow)(this.Rows.Find(new object[] {
                            IdConfiguracion})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_ConfiguracionesReglasDataTable cln = ((sy_ConfiguracionesReglasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_ConfiguracionesReglasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdConfiguracion = this.Columns["IdConfiguracion"];
                this.columnnombre = this.Columns["nombre"];
                this.columnValorDefault = this.Columns["ValorDefault"];
                this.columnValor = this.Columns["Valor"];
                this.columnIdRegla = this.Columns["IdRegla"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
                this.columnDescripcion = this.Columns["Descripcion"];
            }
            
            private void InitClass() {
                this.columnIdConfiguracion = new DataColumn("IdConfiguracion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConfiguracion);
                this.columnnombre = new DataColumn("nombre", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnnombre);
                this.columnValorDefault = new DataColumn("ValorDefault", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValorDefault);
                this.columnValor = new DataColumn("Valor", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValor);
                this.columnIdRegla = new DataColumn("IdRegla", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdRegla);
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
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.Constraints.Add(new UniqueConstraint("sy_ConfiguracionesReglasKey1", new DataColumn[] {
                                this.columnIdConfiguracion}, true));
                this.columnIdConfiguracion.AllowDBNull = false;
                this.columnIdConfiguracion.Unique = true;
                this.columnnombre.AllowDBNull = false;
                this.columnIdRegla.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_ConfiguracionesReglasRow Newsy_ConfiguracionesReglasRow() {
                return ((sy_ConfiguracionesReglasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_ConfiguracionesReglasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_ConfiguracionesReglasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_ConfiguracionesReglasRowChanged != null)) {
                    this.sy_ConfiguracionesReglasRowChanged(this, new sy_ConfiguracionesReglasRowChangeEvent(((sy_ConfiguracionesReglasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_ConfiguracionesReglasRowChanging != null)) {
                    this.sy_ConfiguracionesReglasRowChanging(this, new sy_ConfiguracionesReglasRowChangeEvent(((sy_ConfiguracionesReglasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_ConfiguracionesReglasRowDeleted != null)) {
                    this.sy_ConfiguracionesReglasRowDeleted(this, new sy_ConfiguracionesReglasRowChangeEvent(((sy_ConfiguracionesReglasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_ConfiguracionesReglasRowDeleting != null)) {
                    this.sy_ConfiguracionesReglasRowDeleting(this, new sy_ConfiguracionesReglasRowChangeEvent(((sy_ConfiguracionesReglasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_ConfiguracionesReglasRow(sy_ConfiguracionesReglasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_ConfiguracionesReglasRow : DataRow {
            
            private sy_ConfiguracionesReglasDataTable tablesy_ConfiguracionesReglas;
            
            internal sy_ConfiguracionesReglasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_ConfiguracionesReglas = ((sy_ConfiguracionesReglasDataTable)(this.Table));
            }
            
            public string IdConfiguracion {
                get {
                    return ((string)(this[this.tablesy_ConfiguracionesReglas.IdConfiguracionColumn]));
                }
                set {
                    this[this.tablesy_ConfiguracionesReglas.IdConfiguracionColumn] = value;
                }
            }
            
            public string nombre {
                get {
                    return ((string)(this[this.tablesy_ConfiguracionesReglas.nombreColumn]));
                }
                set {
                    this[this.tablesy_ConfiguracionesReglas.nombreColumn] = value;
                }
            }
            
            public string ValorDefault {
                get {
                    try {
                        return ((string)(this[this.tablesy_ConfiguracionesReglas.ValorDefaultColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_ConfiguracionesReglas.ValorDefaultColumn] = value;
                }
            }
            
            public string Valor {
                get {
                    try {
                        return ((string)(this[this.tablesy_ConfiguracionesReglas.ValorColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_ConfiguracionesReglas.ValorColumn] = value;
                }
            }
            
            public string IdRegla {
                get {
                    return ((string)(this[this.tablesy_ConfiguracionesReglas.IdReglaColumn]));
                }
                set {
                    this[this.tablesy_ConfiguracionesReglas.IdReglaColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tablesy_ConfiguracionesReglas.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_ConfiguracionesReglas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablesy_ConfiguracionesReglas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablesy_ConfiguracionesReglas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_ConfiguracionesReglas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_ConfiguracionesReglas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_ConfiguracionesReglas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_ConfiguracionesReglas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_ConfiguracionesReglas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_ConfiguracionesReglas.RowIdColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tablesy_ConfiguracionesReglas.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_ConfiguracionesReglas.DescripcionColumn] = value;
                }
            }
            
            public bool IsValorDefaultNull() {
                return this.IsNull(this.tablesy_ConfiguracionesReglas.ValorDefaultColumn);
            }
            
            public void SetValorDefaultNull() {
                this[this.tablesy_ConfiguracionesReglas.ValorDefaultColumn] = System.Convert.DBNull;
            }
            
            public bool IsValorNull() {
                return this.IsNull(this.tablesy_ConfiguracionesReglas.ValorColumn);
            }
            
            public void SetValorNull() {
                this[this.tablesy_ConfiguracionesReglas.ValorColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tablesy_ConfiguracionesReglas.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tablesy_ConfiguracionesReglas.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_ConfiguracionesReglas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_ConfiguracionesReglas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_ConfiguracionesReglas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_ConfiguracionesReglas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_ConfiguracionesReglas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_ConfiguracionesReglas.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tablesy_ConfiguracionesReglas.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tablesy_ConfiguracionesReglas.DescripcionColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_ConfiguracionesReglasRowChangeEvent : EventArgs {
            
            private sy_ConfiguracionesReglasRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_ConfiguracionesReglasRowChangeEvent(sy_ConfiguracionesReglasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_ConfiguracionesReglasRow Row {
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