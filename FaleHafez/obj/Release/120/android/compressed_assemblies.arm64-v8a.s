	.arch	armv8-a
	.file	"compressed_assemblies.arm64-v8a.arm64-v8a.s"
	.include	"compressed_assemblies.arm64-v8a-data.inc"

	.section	.data.compressed_assembly_descriptors,"aw",@progbits
	.type	.L.compressed_assembly_descriptors, @object
	.p2align	3
.L.compressed_assembly_descriptors:
	/* 0: FaleHafez.dll */
	/* uncompressed_file_size */
	.word	142336
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_0

	/* 1: Java.Interop.dll */
	/* uncompressed_file_size */
	.word	161792
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_1

	/* 2: Mono.Android.dll */
	/* uncompressed_file_size */
	.word	1004544
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_2

	/* 3: Mono.Security.dll */
	/* uncompressed_file_size */
	.word	109056
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_3

	/* 4: System.Core.dll */
	/* uncompressed_file_size */
	.word	54784
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_4

	/* 5: System.Net.Http.dll */
	/* uncompressed_file_size */
	.word	212480
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_5

	/* 6: System.Numerics.dll */
	/* uncompressed_file_size */
	.word	25600
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_6

	/* 7: System.dll */
	/* uncompressed_file_size */
	.word	395776
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_7

	/* 8: Xamarin.AndroidX.Core.dll */
	/* uncompressed_file_size */
	.word	8704
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_8

	/* 9: Xamarin.Essentials.dll */
	/* uncompressed_file_size */
	.word	22528
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_9

	/* 10: Xamarin.Google.Guava.ListenableFuture.dll */
	/* uncompressed_file_size */
	.word	18072
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_10

	/* 11: mscorlib.dll */
	/* uncompressed_file_size */
	.word	1870848
	/* loaded */
	.byte	0
	/* data */
	.zero	3
	.xword	compressed_assembly_data_11

	.size	.L.compressed_assembly_descriptors, 192
	.section	.data.compressed_assemblies,"aw",@progbits
	.type	compressed_assemblies, @object
	.p2align	3
	.global	compressed_assemblies
compressed_assemblies:
	/* count */
	.word	12
	/* descriptors */
	.zero	4
	.xword	.L.compressed_assembly_descriptors
	.size	compressed_assemblies, 16
