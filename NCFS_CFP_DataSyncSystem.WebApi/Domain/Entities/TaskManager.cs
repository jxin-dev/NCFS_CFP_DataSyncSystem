namespace NCFS_CFP_DataSyncSystem.WebApi.Domain.Entities
{
    public class TaskManager
    {
        public Guid Id { get; set; }
        public string TaskType { get; set; }
        public string TaskId { get; set; }
        public string Reference { get; set; }
        public string Status { get; set; }
        public string PropertyReference { get; set; }
        public string PropertyName { get; set; }
        public List<Note> Notes { get; set; }
        public string Client { get; set; }
        public string Location { get; set; }
        public string Level { get; set; }
        public string EquipmentType { get; set; }
        public string Result { get; set; }
        public DateTime DueDate { get; set; }
        public string Technicians { get; set; }
        public string Address { get; set; }
        public string InvoiceNo { get; set; }
        public decimal Amount { get; set; }
        public string CheckAssetReport { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public string StandardPerformance { get; set; }
        public DateTime CerticationDate { get; set; }
        public string Site { get; set; }
        public string Customers { get; set; }
        public string ESM { get; set; }
        public string RoutineTobeAdded { get; set; }
        public string AssetType { get; set; }
        public string Property { get; set; }

    }
}
