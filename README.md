# SiTandur

### Sistem Informasi Manajemen Hasil Panen

![SiTandur_Landing_Page](https://github.com/RayhanAdii/SiTandur/assets/91187378/75379239-f0ec-41a7-8a46-a43024f97fad)

**Kategori**: Aplikasi produktivitas pertanian
<br> **Tipe Aplikasi**: Desktop App menggunakan Windows Presentation Foundation (WPF) C#

## Fitur Aplikasi:
⛅ Menampilkan cuaca dan kelembapan udara dari API sesuai lokasi untuk membantu meninjau performa panen.
<br> 📝 Mencatat dan menyimpan data hasil panen.
<br> 💰 Memantau hasil penjualan ideal dengan mengolah data harga pasar yang diinput admin dan berat hasil panen (dalam kg).

## Cara Instalasi Aplikasi
1. Unduh file .zip melalui tombol berikut
<br> [![Button Shield]](https://drive.google.com/uc?id=12vqM45QzwbgpohgJCHGZibC3hysLPGRc)

[Button Shield]: https://img.shields.io/badge/Unduh_Aplikasi-37a779?style=for-the-badge

2. Ekstrak file .zip yang telah diunduh
3. Install dan jalankan aplikasi `SiTandur.exe`
<br>

## Langkah Penggunaan Aplikasi
Dalam pembuatan aplikasi tersebut kami menerapkan skema bahwa pengguna merupakan klien spesifik dari suatu kelompok tani pusat di daerah tertentu sehingga mula-mula pengguna diberi akses untuk masuk ke halaman admin:
1. Masuk sebagai Admin dengan akun email: admin[at]gmail.com dan password: admin    (ubah [at] menjadi @)
2. Masuk ke bagian dashboard untuk memasukkan data petani dan jenis tanaman.
<br><br>

Setelah role admin selesai menjalankan keperluan, pengguna dapat menutup aplikasi atau beralih menuju role Petani dengan klik tombol `Logout` pada jendela aplikasi. Kemudian, pengguna masuk menuju halaman Petani:
1. Masuk sebagai Petani dengan akun email: dffz[at]gmail.com dan password: daffaganteng    (ubah [at] menjadi @)
2. Masuk ke bagian dashboard petani dan dapat melakukan aktivitas seperti mencari data cuaca real time di form pojok kanan dan menambah data hasil panen di tabel bawah. Pengguna (dalam hal ini kami asumsikan sebagai pihak pengelola administratif kelompok tani) dapat melihat total hasil pendapatan dari hasil panen yang ideal serta dapat melakukan proses tambah, ubah, atau hapus hasil panen.
3. Pengguna dapat logout atau keluar dari aplikasi.
<br>  

<br>

## Tentang Aplikasi

#### Permasalahan yang dipecahkan:
Minimnya sistem terintegrasi untuk pencatatan hasil panen pertanian di Indonesia sehingga (Sensus yang diadakan oleh Badan Pusat Statistik dilakukan sedikitnya empat tahun sekali. Sumber: Badan Pusat Statistik (bps.go.id))

#### Solusi yang diusulkan beserta fitur aplikasi 
Aplikasi desktop SiTandur berfungsi sebagai platform pencatatan hasil panen petani secara rutin sehingga data yang padu dapat terhimpun dengan baik. Aplikasi tersebut juga diharapkan dapat membantu meningkatkan produktivitas sektor agrikultur di Indonesia. 

Aplikasi sejenis yang mirip dengan solusi yang diusulkan adalah [Agriwebb](https://www.agriwebb.com/), yakni merupakan aplikasi _Livestock Management_ yang telah beredar secara komersial di pasaran. Jika dibandingkan dengan aplikasi Agriwebb, aplikasi SiTandur lebih fokus kepada pertanian dan terdapat fitur rekomendasi sederhana berdasarkan cuaca dan musim.

#### Rancangan Aplikasi
1. **Class Diagram**
   <br>![ClassDiagram_SiTandur](https://github.com/RayhanAdii/SiTandur/assets/93387102/65e27bb3-c4a9-4912-b7a3-3ffe87b8d0e1)
   <br>
3. **Entity Relationship Diagram**
   <br>![ERD](https://github.com/RayhanAdii/SiTandur/assets/91187378/2242cb3c-d537-460e-9a75-f80596f92f68)
   <br>
5. **Activity Diagram**
   <br>![Activity](https://github.com/RayhanAdii/SiTandur/assets/91187378/881d73ca-e7bb-4b00-a25b-1730eab89995)

<br>

#### Black Box Testing
Hasil pengujian aplikasi SiTandur dapat dilihat melalui tautan [Software Testing](https://ugm365-my.sharepoint.com/:w:/g/personal/rayhan_adi_wicaksono_365_ugm_ac_id/EUGTX2c8olJOkANipI2vVh8B635ifBuybdcap1dYH18m-Q) berikut.

<br>

## Tentang Kami
#### Tim Klepon Junior Project 2023
Ketua   : Laily Medha Nur Ihsanti [21/474650/TK/52363]
<br>Anggota 1   : Rayhan Adi Wicaksono [21/477186/TK/52550]
<br>Anggota 2   : Daffa Kamal [21/477293/TK/52564]
