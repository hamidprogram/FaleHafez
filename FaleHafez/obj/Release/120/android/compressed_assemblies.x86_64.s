	.file	"compressed_assemblies.x86_64.x86_64.s"
	.include	"compressed_assemblies.x86_64-data.inc"

	.section	.data.compressed_assembly_descriptors,"aw",@progbits
	.type	.L.compressed_assembly_descriptors, @object
	.p2align	4
.L.compressed_assembly_descriptors:
	/* 0: FaleHafez.dll */
	/* uncompressed_file_size */
	.long	142336
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_0

	/* 1: Java.Interop.dll */
	/* uncompressed_file_size */
	.long	161792
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_1

	/* 2: Mono.Android.dll */
	/* uncompressed_file_size */
	.long	1004544
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_2

	/* 3: Mono.Security.dll */
	/* uncompressed_file_size */
	.long	109056
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_3

	/* 4: System.Core.dll */
	/* uncompressed_file_size */
	.long	54784
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_4

	/* 5: System.Net.Http.dll */
	/* uncompressed_file_size */
	.long	212480
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_5

	/* 6: System.Numerics.dll */
	/* uncompressed_file_size */
	.long	25600
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_6

	/* 7: System.dll */
	/* uncompressed_file_size */
	.long	395776
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_7

	/* 8: Xamarin.AndroidX.Core.dll */
	/* uncompressed_file_size */
	.long	8704
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_8

	/* 9: Xamarin.Essentials.dll */
	/* uncompressed_file_size */
	.long	22528
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_9

	/* 10: Xamarin.Google.Guava.ListenableFuture.dll */
	/* uncompressed_file_size */
	.long	18072
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_10

	/* 11: mscorlib.dll */
	/* uncompressed_file_size */
	.long	1870848
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.quad	compressed_assembly_data_11

	.size	.L.compressed_assembly_descriptors, 192
	.section	.data.compressed_assemblies,"aw",@progbits
	.type	compressed_assemblies, @object
	.p2align	3
	.global	compressed_assemblies
compressed_assemblies:
	/* count */
	.long	12
	/* descriptors */
	.zero	4
	.quad	.L.compressed_assembly_descriptors
	.size	compressed_assemblies, 16
