// @ File:  sqlctr.h
//
// This file is generated by the description file processor.
// Please do not edit.

#define MB_CLERK 0
#define MB_PERIODIC_EVICTIONS 2
#define MB_INTERNAL_BENEFIT 4
#define MB_SIMULATION_SIZE 6
#define MB_SIMULATION_BENEFIT 8
#define MB_CLERK_SIZE 10
#define MB_PRESSURE_EVICTIONS 12

#define BUFMGR_OBJECT 14
#define BUF_CACHE_HIT_RATIO 16
#define BUF_EXT_QUEUE_LENGTH 18
#define BUF_FREELIST_STALLS 20
#define BUF_EXT_EVICTIONS 22
#define BUF_BLOCK_WRITES 24
#define BUF_HASHED_PAGE_COUNT 26
#define RBPEX_CACHE_RATIO_BASE 28
#define BUF_EXT_UNREFERENCED_TIME 30
#define BUF_LIFE_EXPECTANCY 32
#define BUF_RECOVERY_WRITES 34
#define BUF_CACHE_RATIO_BASE 36
#define BUF_EXT_FREE_PAGE_COUNT 38
#define BUF_READAHEAD_MICROS 40
#define BUF_EXT_PAGE_COUNT 42
#define BUF_EXT_UTILIZATION 44
#define BUF_CHECKPOINT_WRITES 46
#define BUF_LAZY_WRITES 48
#define BUF_EXT_READS 50
#define BUF_EXT_WRITES 52
#define BUF_BLOCK_READS 54
#define BUF_SLOPE 56
#define RBPEX_CACHE_HIT_RATIO 58
#define BUF_READAHEAD_PAGES 60
#define BUF_TARGET_PAGE_COUNT 62
#define BUF_PAGE_REQUESTS 64

#define BUFNODE_OBJECT 66
#define BUFNODE_LOOKUPS_TO_REMOTE_NODE 68
#define BUFNODE_LIFE_EXPECTANCY 70
#define BUFNODE_HASHED_PAGE_COUNT 72
#define BUFNODE_LOOKUPS_TO_LOCAL_NODE 74

#define GENERAL_OBJECT 76
#define GO_MARS_DEADLOCKS_DETECTED 78
#define GO_SOAP_SESSION_INITIATES 80
#define GO_TRACE_EVT_NOTIF_QUEUE_SIZE 82
#define GO_SOAP_SESSION_TERMINATES 84
#define GO_USER_CONNECTIONS 86
#define GO_USERS_BLOCKED 88
#define GO_HTTP_AUTH_REQS 90
#define GO_TEMP_TABLES_CREATION_RATE 92
#define GO_RELOGINS 94
#define GO_TRANSACTIONS 96
#define GO_TEMP_TABLES_IN_USE 98
#define GO_TEMPDB_PRU_DUP_ID 100
#define GO_TEMPDB_ROWSET_DUP_ID 102
#define GO_TEMP_TABLES_FOR_DESTRUCTION 104
#define GO_LOGICAL_CONNECTIONS 106
#define GO_TRACE_IO_PROVIDER_EVENTLOCK 108
#define GO_NON_ATOMIC_YIELD_RATE 110
#define GO_SOAP_EMPTY_REQS 112
#define GO_LOGINS 114
#define GO_SOAP_WSDL_REQS 116
#define GO_SOAP_QUERY_REQS 118
#define GO_SOAP_SP_REQS 120
#define GO_LOGOUTS 122
#define GO_EVT_NOTIF_DELAYED_DROP 124

#define LOCKS_OBJECT 126
#define LCK_NUM_REQUESTS 128
#define LCK_NUM_TIMEOUTS 130
#define LCK_NUM_TIMEOUTS_NONPROBE 132
#define LCK_TOTAL_WAITTIME 134
#define LCK_NUM_DEADLOCKS 136
#define LCK_AVERAGE_WAITTIME_BASE 138
#define LCK_NUM_WAITS 140
#define LCK_AVERAGE_WAITTIME 142

#define DBMGR_OBJECT 144
#define DB_XLOG_READ 146
#define DB_WPR_STALE_CHECK_BUCKET_MISS 148
#define DB_COMMITTED_GLOBAL_TRAN 150
#define DB_XTP_CTRL_DLC_LATENCY 152
#define DB_CLOUDDB_PARTITIONS 154
#define DB_LOGPOOL_PUSH_NOBUF_LOWMEM 156
#define DB_LOGPOOL_TOTALACTIVELOGSIZE 158
#define DB_PVS_ADD_IN_ROW_DIFF 160
#define DB_CLOUDDB_SECONDARY_PARTITIONS 162
#define DB_CLOUDDB_FWDPEND_PARTITIONS 164
#define DB_LOGPOOL_DISKREADS 166
#define DB_CLOUDDB_WAITING_COPIES 168
#define DB_CLOUDDB_DELETION_PARTITIONS 170
#define DB_FLUSH_WRITE_TIME 172
#define DB_LOGPOOL_HASH_INSERT 174
#define DB_LOG_WRITER_WRITES 176
#define DB_XLOG_READ_LATENCY 178
#define DB_LOGPOOL_REQUESTS_BASE 180
#define DB_TLC_HASH_REMOVE 182
#define DB_FORCED_ABORTED_GLOBAL_TRAN 184
#define DB_ABORTED_GLOBAL_TRAN 186
#define DB_BULK_KILOBYTES 188
#define DB_DATA_SIZE 190
#define DB_TOTAL_XTRAN 192
#define DB_REPLCOUNT 194
#define DB_LOGPOOL_DIST_FROM_EOL 196
#define DB_LOGPOOL_TOTALSHAREDPOOLSIZE 198
#define DB_ACT_XTRAN 200
#define DB_COMMIT_TABLE_SIZE 202
#define DB_LOGPOOL_BEHIND_TRUNC 204
#define DB_PVS_GET_RECORD 206
#define DB_FORCED_COMMITTED_GLOBAL_TRAN 208
#define DB_FLUSH_WAIT_TIME 210
#define DB_LOGCACHE_RATIO 212
#define DB_IN_DOUBT_GLOBAL_TRAN 214
#define DB_LOGCACHE_READS 216
#define DB_MAX_RESPONSE_TIME_GLOBAL_TRAN 218
#define DB_XTP_CTRL_DLC_LATENCY_BASE 220
#define DB_BYTES_FLUSHED 222
#define DB_PVS_GET_IN_ROW_DIFF 224
#define DB_LOG_USED_PERCENT 226
#define DB_LOG_Q_MICROS 228
#define DB_CHECKPOINT_DURATION 230
#define DB_LOGPOOL_REQUEST_OLD_VLF 232
#define DB_LOGPOOL_INVALID_HASH_ENT 234
#define DB_TRACKED_XTRAN 236
#define DB_FLUSHES 238
#define DB_XTP_CTRL_DLC_LATENCY_PEAK 240
#define DB_PVS_ADD_RECORD 242
#define DB_LOGPOOL_PUSH_NO_FREE_POOL 244
#define DB_PARALLEL_REDO 246
#define DB_LOG_SHRINKS 248
#define DB_CLOUDDB_INBUILD_PARTITIONS 250
#define DB_BCK_DB_THROUGHPUT 252
#define DB_AVG_RESP_TIME_GLOBAL_TRAN 254
#define DB_TOTAL_UPDATE_XTRAN 256
#define DB_LOG_USED 258
#define DB_PVS_ALLOCATE_PAGE 260
#define DB_LOGPOOL_REQUESTS 262
#define DB_TAILLOGCACHE_CACHEMISSES 264
#define DB_LOGPOOL_LOGSCAN_PUSH 266
#define DB_GROUP_COMMIT_TIME 268
#define DB_MAX_ACTIVE_GLOBAL_TRAN 270
#define DB_BULK_ROWS 272
#define DB_AVG_RESP_TIME_GLOBAL_BASE 274
#define DB_FLUSH_FILE_BUFFER_CALLS 276
#define DB_MIN_RESPONSE_TIME_GLOBAL_TRAN 278
#define DB_LOG_TRUNCS 280
#define DB_LOG_GROWTHS 282
#define DB_CLOUDDB_FWD_PARTITIONS 284
#define DB_PVS_DEALLOCATE_PAGE 286
#define DB_TOTAL_NOWAIT_XTRAN 288
#define DB_XLOG_READ_LATENCY_BASE 290
#define DB_WPR_ADD_LSN_BUCKET_MISS 292
#define DB_XTP_MEMORY_USED 294
#define DB_LOG_GOVERNOR_TARE 296
#define DB_CLOUDDB_NOTHING_PARTITIONS 298
#define DB_TAILLOGCACHE_BEHIND_TRUNC 300
#define DB_REPLTRANS 302
#define DB_ACTIVE_GLOBAL_TRAN 304
#define DB_FLUSH_WAITS 306
#define DB_XTP_CTRL_LOGBYTES_PROCESSED 308
#define DB_DBCC_MOVERATE 310
#define DB_LOGPOOL_HASH_REMOVE 312
#define DB_CLOUDDB_PRIMARY_PARTITIONS 314
#define DB_LOG_GOVERNOR_USED 316
#define DB_RECOVERY_DURATION 318
#define DB_DBCC_SCANRATE 320
#define DB_LOG_SIZE 322
#define DB_CLOUDDB_CATCHUP_PARTITIONS 324
#define DB_WPR_BUCKET_SWAPS 326
#define DB_TAILLOGCACHE_LOGWRITER_PUSH 328
#define DB_LOGPOOL_LOGWRITER_PUSH 330
#define DB_LOGPOOL_PUSH_NO_FREE_BUFFER 332
#define DB_LOGPOOL_CACHEMISSES 334
#define DB_LOGCACHE_BASE 336

#define LP_FREEPOOL_OBJECT 338
#define LP_FREEPOOL_FREELIST_LEN 340
#define LP_FREEPOOL_REFILL_BUF 342

#define TAILLOGCACHE_OBJECT 344
#define TLC_FREEPOOL_FREELIST_LEN 346
#define TLC_HASHENTRY_COUNT 348

#define LC_OBJECT 350
#define LC_PAYLOAD_BYTES 352
#define LC_DEFUNCT_CLEANUPS 354
#define LC_QUEUE_TIME 356
#define LC_THROTTLED_WRITE_TIME 358
#define LC_DIRECT_TO_DATA 360
#define LC_LOG_LOOKUP_TIME 362
#define LC_READ_BYTES 364
#define LC_MAP_STALL_TIME 366
#define LC_READ_BYTES_FROM_LOG 368
#define LC_LOOKUP_TIME 370
#define LC_BACKGROUND_WRITES 372
#define LC_BACKGROUND_STALLS 374
#define LC_READ_BYTES_FROM_DATA 376
#define LC_SECTOR_MAPS 378
#define LC_QUEUE_DEPTH 380
#define LC_MAP_CLEARED_IN_MOVE 382
#define LC_MOVE_TO_DATA 384
#define LC_MAP_INDEX_IOS 386
#define LC_MAP_TABLE_IOS 388
#define LC_THROTTLED_WRITES 390
#define LC_HARDEN_TIME 392
#define LC_MAP_TIME 394

#define DBMIRRORING_OBJECT 396
#define DB_DBMIRRORING_SENDS 398
#define DB_DBM_COMP_LOG_BYTES_SENT 400
#define DB_DBM_ACK_TIME 402
#define DB_DBM_REDO_DELTA 404
#define DB_DBM_COMP_LOG_BYTES_RECEIVED 406
#define DB_DBM_LOG_SEND_QUEUE 408
#define DB_DBMIRRORING_BYTES_SENT 410
#define DB_DBM_LOG_BYTES_SENT 412
#define DB_DBM_LOG_UNDO_REMAINING 414
#define DB_DBM_RECEIVES 416
#define DB_DBM_LOG_HARDEN_TIME 418
#define DB_DBM_BYTES_RECEIVED 420
#define DB_DBM_LOG_FLOW_CONTROL 422
#define DB_DBM_LOG_SENT_FROM_CACHE 424
#define DB_DBM_LOG_REDONE_FROM_CACHE 426
#define DB_DBMIRRORING_TRANSACTION_DELAY 428
#define DB_DBM_UPDATE_XTRAN 430
#define DB_DBM_LOG_BYTES_RECEIVED 432
#define DB_DBM_LOG_UNDONE 434
#define DB_DBM_REDO_RATE 436
#define DB_DBMIRRORING_PAGES_SENT 438

#define HADR_DB_OBJECT 440
#define HADR_DB_UNDO_LOG_REMAINING 442
#define HADR_DB_FLOW_CONTROL_COUNT 444
#define HADR_DB_LOG_COMPRESSION_COUNT 446
#define HADR_DB_LOG_REDONE 448
#define HADR_DB_LOG_COMPRESSION_SIZE 450
#define HADR_DB_LOG_APPLY_PENDING_QUEUE 452
#define HADR_DB_LOG_RECEIVED 454
#define HADR_DB_RECOVERY_QUEUE 456
#define HADR_DB_UPDATE_XTRAN 458
#define HADR_DB_REDO_BLOCKED 460
#define HADR_DB_GROUP_COMMIT_TIME 462
#define HADR_DB_FILEBYTES_RECEIVED 464
#define HADR_DB_TRANSACTION_DELAY 466
#define HADR_DB_REDO_REMAINING 468
#define HADR_DB_LOG_QUEUE 470
#define HADR_DB_FLOW_CONTROL_TIME 472
#define HADR_DB_LOG_COMPRESSION_MISS 474
#define HADR_DB_LOG_DECOMPRESSION_SIZE 476
#define HADR_DB_LOG_REDONE_COUNT 478
#define HADR_DB_LOG_COMPRESSION_HIT 480
#define HADR_DB_GROUP_COMMIT_COUNT 482
#define HADR_DB_LOG_DECOMPRESSION_COUNT 484
#define HADR_DB_UNDO_LOG_TOTAL 486
#define HADR_DB_LOG_APPLY_READY_QUEUE 488

#define HADR_OBJECT 490
#define HADR_SEND 492
#define HADR_FLOW_CONTROLS 494
#define HADR_RESENDS 496
#define HADR_FLOW_CONTROL_MS 498
#define HADR_BYTES_RECEIVED 500
#define HADR_BYTES_SENT_TRANSPORT 502
#define HADR_SEND_TRANSPORT 504
#define HADR_BYTES_SENT 506
#define HADR_RECEIVES 508

#define LATCH_OBJECT 510
#define LATCH_WAITS_NP 512
#define LATCH_DEMOTIONS 514
#define LATCH_TOTAL_WAIT_NP 516
#define LATCH_AVG_WAIT_BASE 518
#define LATCH_PROMOTIONS 520
#define LATCH_SUPERLATCHES 522
#define LATCH_AVG_WAIT_NP 524

#define ACCESS_METHODS_OBJECT 526
#define LEAF_PAGE_COOKIE_FAIL 528
#define AM_GHOSTED_SKIPS 530
#define AM_SCAN_REPOSITION 532
#define AM_DEFDROPPEDROWSETSCLEANED 534
#define AM_LOBSS_LOBHANDLES_CREATED 536
#define AM_ORPHANS_CREATED 538
#define AM_PROBE_SCAN 540
#define AM_LOB_READAHEAD_ISSUED 542
#define TREE_PAGE_COOKIE_SUCCEED 544
#define AM_WORKTABLES_FROM_CACHE_BASE 546
#define AM_EXTENTS_ALLOCATED 548
#define AM_COLS_PUSHED_OFFROW 550
#define AM_PAGE_COMPRESSION_SUCCESSES 552
#define AM_DDALLOCUNITBATCHESCOMPLETED 554
#define AM_WORKTABLES_FROM_CACHE 556
#define AM_RANGE_SCAN 558
#define AM_PAGE_COMPRESSION_ATTEMPTS 560
#define AM_COLS_PULLED_INROW 562
#define AM_DDALLOCUNITBATCHESFAILED 564
#define AM_FREESPACE_SCANS 566
#define TREE_PAGE_COOKIE_FAIL 568
#define AM_PAGE_DEALLOCS 570
#define AM_FULL_SCAN 572
#define AM_LOCKESCALATIONS 574
#define AM_FORWARDED_RECS 576
#define AM_ORPHANS_INSERTED 578
#define AM_DEFDROPPEDROWSETQUEUELENGTH 580
#define AM_PAGE_SPLITS 582
#define AM_INSYSXACT_WAITS 584
#define AM_LOBSS_PROVIDERS_TRUNCATED 586
#define AM_DEFDROPPEDROWSETSSKIPPED 588
#define LEAF_PAGE_COOKIE_SUCCEED 590
#define AM_FREESPACE_PAGES 592
#define AM_DDALLOCUNITQUEUELENGTH 594
#define AM_PAGES_ALLOCATED 596
#define AM_LOBSS_PROVIDERS_CREATED 598
#define AM_WORKFILES_CREATED 600
#define AM_EXTENTS_DEALLOCATED 602
#define AM_LOBSS_LOBHANDLES_DESTROYED 604
#define AM_INDEX_SEARCHES 606
#define AM_DDALLOCUNITSCLEANED 608
#define AM_SINGLE_PAGE_ALLOCS 610
#define AM_WORKTABLES_CREATED 612
#define AM_LOBSS_PROVIDERS_DESTROYED 614

#define SQL_ERROR_OBJECT 616
#define SQL_ERROR_RATE 618

#define SQL_OBJECT 620
#define SQL_AUTOPARAM_FAIL 622
#define SQL_AUTOPARAM_UNSAFE 624
#define PLAN_CACHE_MISGUIDED_PER_SEC 626
#define SQL_ATTENTION_RATE 628
#define SQL_UNIVPARAM 630
#define SQL_AUTOPARAM_SAFE 632
#define SQL_BATCH_REQ 634
#define PLAN_CACHE_GUIDED_PER_SEC 636
#define SQL_RECOMPILES 638
#define SQL_COMPILES 640
#define SQL_AUTOPARAM_REQ 642

#define PLAN_CACHE 644
#define PLAN_CACHE_OBJECT_COUNT 646
#define PLAN_CACHE_HIT_RATIO_BASE 648
#define PLAN_CACHE_PGS_IN_USE 650
#define PLAN_CACHE_HIT_RATIO 652
#define PLAN_CACHE_USE_COUNT 654

#define CURSOR_OBJECT_BY_TYPE 656
#define CURSOR_MEMORY_USAGE 658
#define CURSOR_CACHE_HIT_RATIO 660
#define CURSOR_CACHE_USE_COUNT 662
#define CURSOR_PLANS 664
#define CURSOR_CACHE_COUNT 666
#define CURSOR_REQ 668
#define CURSOR_CACHE_HIT_RATIO_BASE 670
#define CURSOR_WORKTABLE_USAGE 672
#define CURSOR_IN_USE 674

#define CURSOR_OBJECT_TOTAL 676
#define CURSOR_CONVERSION_RATE 678
#define CURSOR_XSTMT_FLUSH 680
#define CURSOR_ASYNC_POPULATION 682

#define MEMORY_OBJECT 684
#define MEMORY_SQL_CACHE_MEMORY 686
#define MEMORY_MEMGRANT_MAXIMUM 688
#define MEMORY_LOG_POOL_MEMORY 690
#define MEMORY_EXTERNAL_BENEFIT 692
#define MEMORY_SERVER_MEMORY_TARGET 694
#define MEMORY_SERVER_FREE 696
#define MEMORY_LOCKOWNERS_ALLOCATED 698
#define MEMORY_DECOMMIT_MEMORY 700
#define MEMORY_MEMGRANT_ACQUIRES 702
#define MEMORY_SERVER_MEMORY 704
#define MEMORY_LOCKS 706
#define MEMORY_SERVER_STOLEN 708
#define MEMORY_MEMGRANT_WAITERS 710
#define MEMORY_SERVER_DATABASE 712
#define MEMORY_LOCK_MEMORY 714
#define MEMORY_LOCKOWNERS 716
#define MEMORY_CONNECTION_MEMORY 718
#define MEMORY_LOCKS_ALLOCATED 720
#define MEMORY_OPTIMIZER_MEMORY 722
#define MEMORY_SERVER_RESERVED 724
#define MEMORY_MEMGRANT_OUTSTANDING 726

#define MEMNODE_OBJECT 728
#define MEMNODE_FOREIGN 730
#define MEMNODE_FREE 732
#define MEMNODE_TARGET 734
#define MEMNODE_DATABASE 736
#define MEMNODE_TOTAL 738
#define MEMNODE_DECOMMIT 740
#define MEMNODE_STOLEN 742

#define USER_QUERY_OBJECT 744
#define QUERY_INSTANCE 746

#define REPLICATION_AGENT_OBJECT 748
#define RUNNING_INSTANCE 750

#define MERGE_AGENT_OBJECT 752
#define UPLOAD_INSTANCE 754
#define MERGE_CONFLICTS_INSTANCE 756
#define DOWNLOAD_INSTANCE 758

#define LOGREADER_AGENT_OBJECT 760
#define LOGREADER_COMMANDS_INSTANCE 762
#define LOGREADER_LATENCY_INSTANCE 764
#define LOGREADER_TRANSACTIONS_INSTANCE 766

#define DISTRIBUTION_AGENT_OBJECT 768
#define DISTRIBUTION_TRANS_INSTANCE 770
#define DISTRIBUTION_COMMANDS_INSTANCE 772
#define DISTRIBUTION_LATENCY_INSTANCE 774

#define SNAPSHOT_AGENT_OBJECT 776
#define SNAPSHOT_TRANSACTIONS_BCPED 778
#define SNAPSHOT_COMMANDS_BCPED 780

#define BACKUP_DEV_OBJECT 782
#define BACKUP_DEV_THROUGHPUT 784

#define XACT_OBJECT 786
#define XACT_VER_STORE_SIZE 788
#define XACT_LONGEST_RUNNING 790
#define XACT_NUM 792
#define XACT_VER_STORE_UNIT_TRUNCATION 794
#define XACT_NSNP_VER_NUM 796
#define XACT_SNP_NUM 798
#define XACT_UPD_SNP_NUM 800
#define XACT_VER_STORE_UNIT_COUNT 802
#define XACT_VER_STORE_UNIT_CREATION 804
#define XACT_VER_STORE_GEN_RATE 806
#define XACT_VER_STORE_CLEANUP_RATE 808
#define XACT_TEMPDB_FREE_SPACE 810
#define XACT_UPD_CONFLICTS_RATIO 812
#define XACT_UPD_CONFLICTS_RATIO_BASE 814

#define BROKER_OBJECT 816
#define BO_ENQUEUED_PRI8_MSG_RATE 818
#define BO_ENQUEUED_PRI3_MSG_RATE 820
#define BO_ENQUEUED_PRI7_MSG_RATE 822
#define BO_ENQUEUED_TRANSPORT_FRAG_RATE 824
#define BO_ENQUEUED_PRI4_MSG_RATE 826
#define BO_TOTAL_SENDS 828
#define BO_ENQUEUED_TRANSPORT_FRAGS_TOT 830
#define BO_RECEIVE_RATE 832
#define BO_ENQUEUED_MSGS_TOTAL 834
#define BO_ENQUEUED_PRI10_MSG_RATE 836
#define BO_CORRUPTED_MSGS 838
#define BO_XMITQ_DEQUEUE_RATE 840
#define BO_ENQUEUED_MSG_RATE 842
#define BO_SEND_RATE 844
#define BO_FORWARDED_DISCARDED_MSG_TOTAL 846
#define BO_DEP_TIMER_EVENTS 848
#define BO_ACTIVATION_EXCEPTIONS 850
#define BO_XMITQ_ENQUEUE_RATE 852
#define BO_FORWARDED_MSG_BYTE_RATE 854
#define BO_FORWARDED_PENDING_MSGS 856
#define BO_DROPPED_MSGS 858
#define BO_TOTAL_RECEIVES 860
#define BO_ENQUEUED_TRANSPORT_MSG_RATE 862
#define BO_ENQUEUED_LOCAL_MSGS_TOTAL 864
#define BO_ENQUEUED_PRI1_MSG_RATE 866
#define BO_XACT_ROLLBACKS 868
#define BO_ENQUEUED_PRI9_MSG_RATE 870
#define BO_FORWARDED_PENDING_MSG_BYTES 872
#define BO_FORWARDED_MSG_TOTAL 874
#define BO_ENQUEUED_PRI6_MSG_RATE 876
#define BO_ENQUEUED_LOCAL_MSG_RATE 878
#define BO_FORWARDED_MSG_RATE 880
#define BO_FORWARDED_DISCARDED_MSG_RATE 882
#define BO_ENQUEUED_PRI5_MSG_RATE 884
#define BO_ENQUEUED_TRANSPORT_MSGS_TOTAL 886
#define BO_FORWARDED_MSG_BYTE_TOTAL 888
#define BO_ENQUEUED_PRI2_MSG_RATE 890

#define BROKER_TRANSPORT_OBJECT 892
#define BTO_RECV_FRAG_SIZE_AVG 894
#define BTO_SEND_IO_CURR_FRAG_COUNT 896
#define BTO_SEND_FC_ENTER_COUNT 898
#define BTO_SEND_FRAG_RATE 900
#define BTO_SEND_IO_RATE 902
#define BTO_RECEIVE_IO_BYTE_RATE 904
#define BTO_SEND_FRAG_RATE_PRI6 906
#define BTO_DECRYPT_IO_BYTE_RATE 908
#define BTO_SEND_FRAG_RATE_PRI7 910
#define BTO_SEND_IO_LEN_AVG 912
#define BTO_SEND_FRAG_RATE_PRI5 914
#define BTO_SEND_FRAG_SIZE_AVG 916
#define BTO_OPEN_CONNECTIONS 918
#define BTO_SEND_IO_BYTE_RATE 920
#define BTO_SEND_FRAG_RATE_PRI4 922
#define BTO_SEND_FC_EXIT_COUNT 924
#define BTO_RECV_IO_COMPACT_MFB 926
#define BTO_RECV_IO_LEN_AVG 928
#define BTO_SEND_IO_LEN_AVG_BASE 930
#define BTO_ENCRYPT_IO_BYTE_RATE 932
#define BTO_SEND_FRAG_SIZE_AVG_BASE 934
#define BTO_RECV_FC_ENTER_COUNT 936
#define BTO_RECV_IO_LEN_AVG_BASE 938
#define BTO_SEND_FRAG_RATE_PRI1 940
#define BTO_SEND_FRAG_RATE_PRI2 942
#define BTO_RECV_IO_PEND_BYTES 944
#define BTO_RECV_FRAG_SIZE_AVG_BASE 946
#define BTO_RECEIVE_FRAG_RATE 948
#define BTO_SEND_FRAG_RATE_PRI3 950
#define BTO_SEND_FRAG_RATE_PRI9 952
#define BTO_SEND_IO_CURR_BYTES 954
#define BTO_RECV_IO_PEND_FRAG_COUNT 956
#define BTO_SEND_FRAG_RATE_PRI8 958
#define BTO_RECEIVE_IO_RATE 960
#define BTO_SEND_FRAG_RATE_PRI10 962
#define BTO_SEND_FC_GATE 964
#define BTO_SEND_IO_PEND_BYTES 966
#define BTO_ENCRYPT_IO_RATE 968
#define BTO_RECV_IO_COMPACT_MFB_RATE 970
#define BTO_SEND_IO_PEND_FRAG_COUNT 972
#define BTO_RECV_FC_GATE 974
#define BTO_RECV_FC_EXIT_COUNT 976
#define BTO_RECV_IO_CURR_BYTES 978
#define BTO_DECRYPT_IO_RATE 980

#define BROKER_ACTIVATION_OBJECT 982
#define BAO_TASK_LIMIT_RATE 984
#define BAO_TASK_LIMIT_REACHED 986
#define BAO_TASKS_RUNNING 988
#define BAO_SP_INVOKE_RATE 990
#define BAO_TASK_ABORT_RATE 992
#define BAO_TASK_START_RATE 994

#define BROKER_TRANSMISSION_OBJECT 996
#define BTO_WRITE_RATE 998
#define BTO_WRITE_BATCH_LEN 1000
#define BTO_WRITE_BATCH_TIME 1002
#define BTO_WAIT_BATCH_TIME_BASE 1004
#define BTO_WAIT_BATCH_TIME 1006
#define BTO_WRITE_BATCH_LEN_BASE 1008
#define BTO_DIRTY_RATE 1010
#define BTO_GET_RATE 1012
#define BTO_WRITE_BATCH_TIME_BASE 1014

#define WAITSTATS_OBJECT 1016
#define WAITSTATS_XACTWORKSPACE 1018
#define WAITSTATS_NPAGELATCH 1020
#define WAITSTATS_PAGELATCH 1022
#define WAITSTATS_MEMTHREAD 1024
#define WAITSTATS_PAGEIOLATCH 1026
#define WAITSTATS_SOS_WORKER 1028
#define WAITSTATS_WRITELOG 1030
#define WAITSTATS_TRANSACTION 1032
#define WAITSTATS_LOCKS 1034
#define WAITSTATS_NETWORKIO 1036
#define WAITSTATS_RESOURCE 1038
#define WAITSTATS_LOGBUFFER 1040

#define EXECSTATS_OBJECT 1042
#define EXECSTATS_OLEDB 1044
#define EXECSTATS_DQ 1046
#define EXECSTATS_DTC 1048
#define EXECSTATS_MSQL_XP 1050

#define SQLCLR_OBJECT 1052
#define SQLCLR_TOTAL_EXECTIME 1054

#define METADATAMGR_OBJECT 1056
#define MD_CACHE_ENTRY_COUNT 1058
#define MD_CACHE_HIT_RATIO 1060
#define MD_CACHE_HIT_RATIO_BASE 1062
#define MD_CACHE_PINNED_COUNT 1064

#define CLOUD_MSG_OBJECT 1066
#define CLOUD_MSG_RECV_RATE 1068
#define CLOUD_MSG_SENT_BYTES_RATE 1070
#define CLOUD_MSG_SENT_RATE 1072
#define CLOUD_MSG_RECV_BYTES_RATE 1074

#define CLOUD_REPL_OBJECT 1076
#define CLOUD_REPL_ACTIVE_DELETE_SCANS 1078
#define CLOUD_REPL_QUEUE_SIZE 1080
#define CLOUD_REPL_PENDING_COPY_SCANS 1082
#define CLOUD_REPL_ACTIVE_COPY_SCANS 1084
#define CLOUD_REPL_PENDING_DELETE_SCANS 1086
#define CLOUD_REPL_ACTIVE_CATCHUP_SCANS 1088
#define CLOUD_REPL_COMMIT_SECONDARY 1090
#define CLOUD_REPL_COMMIT_PRIMARY 1092

#define TRACE_STATISTICS 1094
#define TS_DROPPED_EVENTS 1096
#define TS_BYTES 1098
#define TS_EVENTS_FIRED 1100
#define TS_EVENTS_FILTERED 1102

#define TRACE_EVENT_STATISTICS 1104
#define TES_EVENTS_FILTERED 1106
#define TES_EVENTS_PREFILTERED 1108
#define TES_CPU_USAGE 1110
#define TES_BYTES 1112
#define TES_EVENTS_FIRED 1114

#define DEPRECATED_FEATURES 1116
#define DEPR_USAGE 1118

#define RESOURCE_GROUP_STATISTICS 1120
#define RGS_CPU_DELAYED_PERCENT 1122
#define RGS_QUEUED_REQUESTS 1124
#define RGS_READS_STALL_BASE 1126
#define RGS_REQUESTS_COMPLETED 1128
#define RGS_VIOLATIONS 1130
#define RGS_READS_BYTES 1132
#define RGS_CPU_DELAYED_PERCENT_BASE 1134
#define RGS_WRITES_STALL 1136
#define RGS_SUBOPTIMAL_PLANS 1138
#define RGS_MAX_REQUEST_MEMGRANT 1140
#define RGS_CPU_EFFECTIVE_PERCENT 1142
#define RGS_CPU_USAGE_BASE 1144
#define RGS_READS_STALL 1146
#define RGS_ACTIVE_PARALLEL_THREADS 1148
#define RGS_WRITES_STALL_BASE 1150
#define RGS_WRITES_BYTES 1152
#define RGS_READS_COMPLETED 1154
#define RGS_ACTIVE_REQUESTS 1156
#define RGS_QUERY_OPTIMIZATIONS 1158
#define RGS_CPU_VIOLATED 1160
#define RGS_CPU_EFFECTIVE_PERCENT_BASE 1162
#define RGS_CPU_USAGE 1164
#define RGS_REDUCED_MEMGRANTS_COUNT 1166
#define RGS_WRITES_COMPLETED 1168
#define RGS_BLOCKED_TASKS 1170
#define RGS_MAX_REQUEST_CPU 1172

#define RESOURCE_POOL_STATISTICS 1174
#define RPS_MAX_MEMORY 1176
#define RPS_MEMORY_GRANTS_COUNT 1178
#define RPS_READS_THROTTLED 1180
#define RPS_ACTIVE_MEMGRANT 1182
#define RPS_WRITES_BYTES 1184
#define RPS_CPU_USAGE_NONGOVERNED 1186
#define RPS_MEMORY_USAGE 1188
#define RPS_WRITES_ISSUED 1190
#define RPS_WRITES_COMPLETED 1192
#define RPS_CACHE_MEMORY_TARGET 1194
#define RPS_PENDING_MEMGRANTS 1196
#define RPS_COMPILE_MEMORY_TARGET 1198
#define RPS_CPU_USAGE_BASE 1200
#define RPS_READS_BYTES 1202
#define RPS_CPU_EFFECTIVE_PERCENT_BASE 1204
#define RPS_QUERY_EXEC_MEMORY_TARGET 1206
#define RPS_WRITES_THROTTLED 1208
#define RPS_CPU_USAGE 1210
#define RPS_TARGET_MEMORY 1212
#define RPS_ACTIVE_MEMGRANTS_COUNT 1214
#define RPS_CPU_USAGE_PROJECTED 1216
#define RPS_WRITES_STALL 1218
#define RPS_READS_STALL_BASE 1220
#define RPS_CPU_DELAYED_PERCENT_BASE 1222
#define RPS_CPU_EFFECTIVE_PERCENT 1224
#define RPS_READS_ISSUED 1226
#define RPS_READS_STALL 1228
#define RPS_CPU_DELAYED_PERCENT 1230
#define RPS_MEMORY_GRANT_TIMEOUT 1232
#define RPS_CPU_VIOLATED 1234
#define RPS_READS_COMPLETED 1236
#define RPS_WRITES_STALL_BASE 1238

#define TCM_STATISTICS 1240
#define AGE_HARDEN_TIME_BASE 1242
#define AGE_HARDEN_TIME 1244
#define AGE_RESPONSES 1246
#define AGE_LIFETIME_BASE 1248
#define ORDERS_BROADCAST 1250
#define AGE_LIFETIME 1252
#define AGE_SIZE_BASE 1254
#define AGE_BROADCASTS 1256
#define AGE_SIZE 1258

#define TCMA_STATISTICS 1260
#define MATRIX_XACT_STARTED 1262
#define MXACT_PARTICIPANTS 1264
#define AGE_PROCESSING_TIME 1266
#define XACTION_REQUESTS_PER_AGE_BASE 1268
#define AGE_PROCESSING_TIME_BASE 1270
#define XACTION_COMMITED_PER_AGE 1272
#define XACTION_REQUESTS_PER_AGE 1274
#define COMMIT_WAITTIME 1276
#define TRANSACTION_PREPARE_TIME 1278
#define MATRIX_XACT_COMMITTED 1280
#define MXACT_BRANCHES 1282
#define COMMIT_WAITTIME_BASE 1284
#define XACTION_COMMITED_PER_AGE_BASE 1286
#define MATRIX_XACT_ROLLEDBACK 1288
#define TRANSACTION_PREPARE_TIME_BASE 1290

#define FILETABLE_STATISTICS 1292
#define FILETABLE_ENUMERATION_REQUESTS 1294
#define FILETABLE_FILEIO_REQ_TIME_BASE 1296
#define FILETABLE_ENUMERATION_TIME 1298
#define FILETABLE_FILEIO_RESP_TIME_BASE 1300
#define FILETABLE_ITEM_RENAME_TIME 1302
#define FILETABLE_FILEIO_RESPONSES 1304
#define FILETABLE_ITEM_MOVE_TIME 1306
#define FILETABLE_TABLE_OPERATIONS 1308
#define FILETABLE_HANDLE_KILL_OPERATIONS 1310
#define FILETABLE_ITEM_RENAME_REQUESTS 1312
#define FILETABLE_ITEM_DELETE_TIME_BASE 1314
#define FILETABLE_HANDLE_KILL_TIME_BASE 1316
#define FILETABLE_FILEIO_REQ_TIME 1318
#define FILETABLE_FILEIO_RESP_TIME 1320
#define FILETABLE_ENUMERATION_TIME_BASE 1322
#define FILETABLE_ITEM_UPDATE_TIME_BASE 1324
#define FILETABLE_ITEM_GET_REQUESTS 1326
#define FILETABLE_ITEM_GET_REQ_TIME 1328
#define FILETABLE_ITEM_MOVE_REQUESTS 1330
#define FILETABLE_FILEIO_REQUESTS 1332
#define FILETABLE_ITEM_MOVE_TIME_BASE 1334
#define FILETABLE_HANDLE_KILL_TIME 1336
#define FILETABLE_ITEM_GET_REQ_TIME_BASE 1338
#define FILETABLE_DATABASE_OPERATIONS 1340
#define FILETABLE_ITEM_UPDATE_TIME 1342
#define FILETABLE_ITEM_DELETE_REQUESTS 1344
#define FILETABLE_ITEM_UPDATE_REQUESTS 1346
#define FILETABLE_ITEM_DELETE_TIME 1348
#define FILETABLE_ITEM_RENAME_TIME_BASE 1350

#define SQL_BATCH_RESPONSE_TIME 1352
#define SQL_BATCH_RES_10 1354
#define SQL_BATCH_RES_2 1356
#define SQL_BATCH_RES_100S 1358
#define SQL_BATCH_RES_50S 1360
#define SQL_BATCH_RES_5S 1362
#define SQL_BATCH_RES_500 1364
#define SQL_BATCH_RES_0 1366
#define SQL_BATCH_RES_1 1368
#define SQL_BATCH_RES_50 1370
#define SQL_BATCH_RES_5 1372
#define SQL_BATCH_RES_20S 1374
#define SQL_BATCH_RES_100 1376
#define SQL_BATCH_RES_2S 1378
#define SQL_BATCH_RES_10S 1380
#define SQL_BATCH_RES_200 1382
#define SQL_BATCH_RES_20 1384
#define SQL_BATCH_RES_1S 1386

#define SOFT_ENGINE_THROTTLING_PARTITION 1388
#define ST_DATA_READ_IO_DELAY 1390
#define ST_LOG_WRITE_IO_DELAY 1392
#define ST_DATA_SPACE 1394
#define ST_BUSY_WORKERS 1396
#define ST_LOG_SPACE 1398

#define HARD_ENGINE_THROTTLING_PARTITION 1400
#define HT_LOG_WRITE_IO_DELAY 1402
#define HT_LOG_SPACE 1404
#define HT_DATA_SPACE 1406
#define HT_DATA_READ_IO_DELAY 1408
#define HT_BUSY_WORKERS 1410

#define HTTP_STORAGE_OBJECT 1412
#define HSO_uSEC_PER_READ_BASE 1414
#define HSO_TRANSFERS 1416
#define HSO_BYTES_PER_WRITE_BASE 1418
#define HSO_REQUEST_RETRY 1420
#define HSO_BYTES_PER_READ 1422
#define HSO_uSEC_PER_WRITE_BASE 1424
#define HSO_uSEC_PER_READ_COMP 1426
#define HSO_READS 1428
#define HSO_uSEC_PER_WRITE_COMP 1430
#define HSO_uSEC_PER_READ 1432
#define HSO_BYTES_PER_TRANSFER_BASE 1434
#define HSO_TOTAL_BYTES 1436
#define HSO_uSEC_PER_TRANSFER 1438
#define HSO_READ_BYTES 1440
#define HSO_uSEC_PER_WRITE 1442
#define HSO_WRITE_BYTES 1444
#define HSO_REQUEST_FAILURE 1446
#define HSO_WRITES 1448
#define HSO_uSEC_PER_WRITE_COMP_BASE 1450
#define HSO_uSEC_PER_READ_COMP_BASE 1452
#define HSO_BYTES_PER_WRITE 1454
#define HSO_BYTES_PER_READ_BASE 1456
#define HSO_uSEC_PER_TRANSFER_BASE 1458
#define HSO_OUTSTANDING_IO 1460
#define HSO_BYTES_PER_TRANSFER 1462

#define DB_XE_SESSION 1464
#define DB_XE_SESSION_DB_CAP_HITS 1466
#define DB_XE_SESSION_START_FAILURES 1468
#define DB_XE_SESSION_ACTIVE_SESSIONS 1470
#define DB_XE_SESSION_TIMEOUTS 1472
#define DB_XE_SESSION_DROPPED_BUFFERS 1474
#define DB_XE_SESSION_SERVER_CAP_HITS 1476
#define DB_XE_SESSION_DROPPED_EVENTS 1478

#define QDS_OBJECT 1480
#define QDS_PHYSICAL_READS 1482
#define QDS_LOGICAL_WRITES 1484
#define QDS_LOGICAL_READS 1486
#define QDS_CPU_USAGE 1488

#define COLUMNSTORE_OBJECT 1490
#define CS_DELTA_ROWGROUPS_CLOSED 1492
#define CS_DELTA_ROWGROUPS_COMPRESSED 1494
#define CS_SEGMENT_CACHE_RATIO_BASE 1496
#define CS_SOURCE_ROWGROUPS_MERGED 1498
#define CS_DELTA_ROWGROUPS_CREATED 1500
#define CS_TOTAL_ROWGROUPS_COMPRESSED 1502
#define CS_SEGMENT_READS 1504
#define CS_TOTAL_DELETE_BUFFERS_MIGRATED 1506
#define CS_ROWGROUPS_FIT_FOR_MERGE 1508
#define CS_MERGE_POLICY_EVALUATIONS 1510
#define CS_ROWGROUPS_MERGE_COMPRESSED 1512
#define CS_SEGMENT_CACHE_RATIO 1514

#define EXTERNALSCRIPT_STATISTICS 1516
#define ES_PARTITION_BY_EXECUTIONS 1518
#define ES_TOTAL_EXECUTION_TIME 1520
#define ES_IMPLIED_AUTH_LOGINS 1522
#define ES_SQLCC_EXECUTIONS 1524
#define ES_TOTAL_EXECUTIONS 1526
#define ES_EXEC_ERRORS 1528
#define ES_STREAMING_EXECUTIONS 1530
#define ES_PARALLEL_EXECUTIONS 1532

#define EXTENSIBILITY_OBJECT 1534
#define EX_TOTAL_PREDICT_QUERIES 1536

#define HADR_AG_OBJECT 1538
#define AG_HADR_TASKS_EXECD 1540

#define JSON_STATISTICS 1542
#define JSON_FUNC_CALLS 1544
#define JSON_DOC_GREATER_32KB_LESS_100KB 1546
#define JSON_DOC_GREATER_8KB_LESS_16KB 1548
#define JSON_DOC_LESS_8KB 1550
#define JSON_DOC_GREATER_16KB_LESS_32KB 1552
#define JSON_DOC_GREATER_100KB 1554