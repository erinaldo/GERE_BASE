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
    public class tsh_GruposProductosDataset : DataSet {
        
        private tsh_GruposProductosDataTable tabletsh_GruposProductos;
        
        public tsh_GruposProductosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsh_GruposProductosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsh_GruposProductos"] != null)) {
                    this.Tables.Add(new tsh_GruposProductosDataTable(ds.Tables["tsh_GruposProductos"]));
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
        public tsh_GruposProductosDataTable tsh_GruposProductos {
            get {
                return this.tabletsh_GruposProductos;
            }
        }
        
        public override DataSet Clone() {
            tsh_GruposProductosDataset cln = ((tsh_GruposProductosDataset)(base.Clone()));
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
            if ((ds.Tables["tsh_GruposProductos"] != null)) {
                this.Tables.Add(new tsh_GruposProductosDataTable(ds.Tables["tsh_GruposProductos"]));
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
            this.tabletsh_GruposProductos = ((tsh_GruposProductosDataTable)(this.Tables["tsh_GruposProductos"]));
            if ((this.tabletsh_GruposProductos != null)) {
                this.tabletsh_GruposProductos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsh_GruposProductosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsh_GruposProductos.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsh_GruposProductos = new tsh_GruposProductosDataTable();
            this.Tables.Add(this.tabletsh_GruposProductos);
        }
        
        private bool ShouldSerializetsh_GruposProductos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsh_GruposProductosRowChangeEventHandler(object sender, tsh_GruposProductosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_GruposProductosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdProducto;
            
            private DataColumn columnIdPadre;
            
            private DataColumn columnOrden;
            
            private DataColumn columnCantidad;
            
            private DataColumn columnBonificacionVisual;
            
            private DataColumn columnFormulaDeCalculoCantidad;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            internal tsh_GruposProductosDataTable() : 
                    base("tsh_GruposProductos") {
                this.InitClass();
            }
            
            internal tsh_GruposProductosDataTable(DataTable table) : 
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
            
            internal DataColumn IdProductoColumn {
                get {
                    return this.columnIdProducto;
                }
            }
            
            internal DataColumn IdPadreColumn {
                get {
                    return this.columnIdPadre;
                }
            }
            
            internal DataColumn OrdenColumn {
                get {
                    return this.columnOrden;
                }
            }
            
            internal DataColumn CantidadColumn {
                get {
                    return this.columnCantidad;
                }
            }
            
            internal DataColumn BonificacionVisualColumn {
                get {
                    return this.columnBonificacionVisual;
                }
            }
            
            internal DataColumn FormulaDeCalculoCantidadColumn {
                get {
                    return this.columnFormulaDeCalculoCantidad;
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
            
            public tsh_GruposProductosRow this[int index] {
                get {
                    return ((tsh_GruposProductosRow)(this.Rows[index]));
                }
            }
            
            public event tsh_GruposProductosRowChangeEventHandler tsh_GruposProductosRowChanged;
            
            public event tsh_GruposProductosRowChangeEventHandler tsh_GruposProductosRowChanging;
            
            public event tsh_GruposProductosRowChangeEventHandler tsh_GruposProductosRowDeleted;
            
            public event tsh_GruposProductosRowChangeEventHandler tsh_GruposProductosRowDeleting;
            
            public void Addtsh_GruposProductosRow(tsh_GruposProductosRow row) {
                this.Rows.Add(row);
            }
            
            public tsh_GruposProductosRow Addtsh_GruposProductosRow(string IdProducto, string IdPadre, int Orden, System.Decimal Cantidad, System.Decimal BonificacionVisual, string FormulaDeCalculoCantidad, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa) {
                tsh_GruposProductosRow rowtsh_GruposProductosRow = ((tsh_GruposProductosRow)(this.NewRow()));
                rowtsh_GruposProductosRow.ItemArray = new object[] {
                        IdProducto,
                        IdPadre,
                        Orden,
                        Cantidad,
                        BonificacionVisual,
                        FormulaDeCalculoCantidad,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa};
                this.Rows.Add(rowtsh_GruposProductosRow);
                return rowtsh_GruposProductosRow;
            }
            
            public tsh_GruposProductosRow FindByIdProductoIdPadreOrden(string IdProducto, string IdPadre, int Orden) {
                return ((tsh_GruposProductosRow)(this.Rows.Find(new object[] {
                            IdProducto,
                            IdPadre,
                            Orden})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsh_GruposProductosDataTable cln = ((tsh_GruposProductosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsh_GruposProductosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdProducto = this.Columns["IdProducto"];
                this.columnIdPadre = this.Columns["IdPadre"];
                this.columnOrden = this.Columns["Orden"];
                this.columnCantidad = this.Columns["Cantidad"];
                this.columnBonificacionVisual = this.Columns["BonificacionVisual"];
                this.columnFormulaDeCalculoCantidad = this.Columns["FormulaDeCalculoCantidad"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
            }
            
            private void InitClass() {
                this.columnIdProducto = new DataColumn("IdProducto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProducto);
                this.columnIdPadre = new DataColumn("IdPadre", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPadre);
                this.columnOrden = new DataColumn("Orden", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOrden);
                this.columnCantidad = new DataColumn("Cantidad", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCantidad);
                this.columnBonificacionVisual = new DataColumn("BonificacionVisual", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnBonificacionVisual);
                this.columnFormulaDeCalculoCantidad = new DataColumn("FormulaDeCalculoCantidad", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFormulaDeCalculoCantidad);
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
                this.Constraints.Add(new UniqueConstraint("tsh_GruposProductosKey1", new DataColumn[] {
                                this.columnIdProducto,
                                this.columnIdPadre,
                                this.columnOrden}, true));
                this.columnIdProducto.AllowDBNull = false;
                this.columnIdPadre.AllowDBNull = false;
                this.columnOrden.AllowDBNull = false;
                this.columnCantidad.AllowDBNull = false;
                this.columnBonificacionVisual.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsh_GruposProductosRow Newtsh_GruposProductosRow() {
                return ((tsh_GruposProductosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsh_GruposProductosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsh_GruposProductosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsh_GruposProductosRowChanged != null)) {
                    this.tsh_GruposProductosRowChanged(this, new tsh_GruposProductosRowChangeEvent(((tsh_GruposProductosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsh_GruposProductosRowChanging != null)) {
                    this.tsh_GruposProductosRowChanging(this, new tsh_GruposProductosRowChangeEvent(((tsh_GruposProductosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsh_GruposProductosRowDeleted != null)) {
                    this.tsh_GruposProductosRowDeleted(this, new tsh_GruposProductosRowChangeEvent(((tsh_GruposProductosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsh_GruposProductosRowDeleting != null)) {
                    this.tsh_GruposProductosRowDeleting(this, new tsh_GruposProductosRowChangeEvent(((tsh_GruposProductosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsh_GruposProductosRow(tsh_GruposProductosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_GruposProductosRow : DataRow {
            
            private tsh_GruposProductosDataTable tabletsh_GruposProductos;
            
            internal tsh_GruposProductosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsh_GruposProductos = ((tsh_GruposProductosDataTable)(this.Table));
            }
            
            public string IdProducto {
                get {
                    return ((string)(this[this.tabletsh_GruposProductos.IdProductoColumn]));
                }
                set {
                    this[this.tabletsh_GruposProductos.IdProductoColumn] = value;
                }
            }
            
            public string IdPadre {
                get {
                    return ((string)(this[this.tabletsh_GruposProductos.IdPadreColumn]));
                }
                set {
                    this[this.tabletsh_GruposProductos.IdPadreColumn] = value;
                }
            }
            
            public int Orden {
                get {
                    return ((int)(this[this.tabletsh_GruposProductos.OrdenColumn]));
                }
                set {
                    this[this.tabletsh_GruposProductos.OrdenColumn] = value;
                }
            }
            
            public System.Decimal Cantidad {
                get {
                    return ((System.Decimal)(this[this.tabletsh_GruposProductos.CantidadColumn]));
                }
                set {
                    this[this.tabletsh_GruposProductos.CantidadColumn] = value;
                }
            }
            
            public System.Decimal BonificacionVisual {
                get {
                    return ((System.Decimal)(this[this.tabletsh_GruposProductos.BonificacionVisualColumn]));
                }
                set {
                    this[this.tabletsh_GruposProductos.BonificacionVisualColumn] = value;
                }
            }
            
            public string FormulaDeCalculoCantidad {
                get {
                    try {
                        return ((string)(this[this.tabletsh_GruposProductos.FormulaDeCalculoCantidadColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_GruposProductos.FormulaDeCalculoCantidadColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsh_GruposProductos.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_GruposProductos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_GruposProductos.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_GruposProductos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsh_GruposProductos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_GruposProductos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_GruposProductos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_GruposProductos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsh_GruposProductos.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_GruposProductos.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsh_GruposProductos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_GruposProductos.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsh_GruposProductos.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_GruposProductos.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsFormulaDeCalculoCantidadNull() {
                return this.IsNull(this.tabletsh_GruposProductos.FormulaDeCalculoCantidadColumn);
            }
            
            public void SetFormulaDeCalculoCantidadNull() {
                this[this.tabletsh_GruposProductos.FormulaDeCalculoCantidadColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsh_GruposProductos.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsh_GruposProductos.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsh_GruposProductos.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsh_GruposProductos.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_GruposProductos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsh_GruposProductos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_GruposProductos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsh_GruposProductos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsh_GruposProductos.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsh_GruposProductos.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsh_GruposProductos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsh_GruposProductos.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsh_GruposProductos.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsh_GruposProductos.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_GruposProductosRowChangeEvent : EventArgs {
            
            private tsh_GruposProductosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsh_GruposProductosRowChangeEvent(tsh_GruposProductosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsh_GruposProductosRow Row {
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
