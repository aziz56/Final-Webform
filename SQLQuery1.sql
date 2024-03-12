SELECT
  t.id_penjualan,
  p.nama_pelanggan,
  t.tanggal_penjualan,
  t.waktu_penjualan,
  t.total_penjualan,
  m.nama_menu,
  m.harga_menu,
  d.jumlah_pesanan,
  pem.amount,
  pem.metode_pembayaran,
  pem.waktu_pembayaran,
  pem.kembalian
FROM TransaksiPenjualan AS t
INNER JOIN TransaksiDetailTransaksi AS d ON t.id_penjualan = d.id_penjualan
INNER JOIN MasterMenu AS m ON d.id_menu = m.id_menu INNER JOIN MasterPelanggan as p ON p.id_pelanggan = t.id_pelanggaan INNER JOIN MasterMeja as mj on mj.id_meja = t.id_meja inner join Pembayaran as pem on pem.id_pembayaran = t.id_pembayaran 
