using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace api_ciscocdr.Models
{
    public partial class CallAnalyzerContext : DbContext
    {
        public CallAnalyzerContext()
        {
        }

        public CallAnalyzerContext(DbContextOptions<CallAnalyzerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Calls> Calls { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Calls>(entity =>
            {
                entity.HasKey(e => e.Pkid)
                    .HasName("PK_dbo.Calls");

                entity.HasIndex(e => e.CallingPartyNumber)
                    .HasName("IX_callingPartyNumber");

                entity.HasIndex(e => e.DestCauseValue)
                    .HasName("IX_destCause_value");

                entity.HasIndex(e => e.DestDeviceName)
                    .HasName("IX_destDeviceName");

                entity.HasIndex(e => e.FinalCalledPartyNumber)
                    .HasName("IX_finalCalledPartyNumber");

                entity.HasIndex(e => e.OrigCauseValue)
                    .HasName("IX_origCause_value");

                entity.HasIndex(e => e.OrigDeviceName)
                    .HasName("IX_origDeviceName");

                entity.HasIndex(e => e.OriginalCalledPartyNumber)
                    .HasName("IX_originalCalledPartyNumber");

                entity.HasIndex(e => new { e.CallingPartyNumber, e.OriginalCalledPartyNumber, e.FinalCalledPartyNumber, e.DateTimeDisconnect })
                    .HasName("Unique")
                    .IsUnique();

                entity.Property(e => e.Pkid)
                    .HasColumnName("pkid")
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthCodeDescription).HasColumnName("authCodeDescription");

                entity.Property(e => e.AuthorizationCodeValue).HasColumnName("authorizationCodeValue");

                entity.Property(e => e.AuthorizationLevel).HasColumnName("authorizationLevel");

                entity.Property(e => e.CallSecuredStatus).HasColumnName("callSecuredStatus");

                entity.Property(e => e.CalledPartyPatternUsage).HasColumnName("calledPartyPatternUsage");

                entity.Property(e => e.CallingPartyNumber)
                    .HasColumnName("callingPartyNumber")
                    .HasMaxLength(64);

                entity.Property(e => e.CallingPartyNumberPartition).HasColumnName("callingPartyNumberPartition");

                entity.Property(e => e.CallingPartyNumberUri).HasColumnName("callingPartyNumber_uri");

                entity.Property(e => e.CallingPartyUnicodeLoginUserId).HasColumnName("callingPartyUnicodeLoginUserID");

                entity.Property(e => e.CdrRecordType).HasColumnName("cdrRecordType");

                entity.Property(e => e.ClientMatterCode).HasColumnName("clientMatterCode");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CurrentRoutingReason).HasColumnName("currentRoutingReason");

                entity.Property(e => e.DateTimeConnect).HasColumnName("dateTimeConnect");

                entity.Property(e => e.DateTimeDisconnect)
                    .HasColumnName("dateTimeDisconnect")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateTimeOrigination).HasColumnName("dateTimeOrigination");

                entity.Property(e => e.DestCallTerminationOnBehalfOf).HasColumnName("destCallTerminationOnBehalfOf");

                entity.Property(e => e.DestCauseLocation).HasColumnName("destCause_location");

                entity.Property(e => e.DestCauseValue)
                    .HasColumnName("destCause_value")
                    .HasMaxLength(64);

                entity.Property(e => e.DestConversationId).HasColumnName("destConversationId");

                entity.Property(e => e.DestDeviceName)
                    .HasColumnName("destDeviceName")
                    .HasMaxLength(64);

                entity.Property(e => e.DestDtmfmethod).HasColumnName("destDTMFMethod");

                entity.Property(e => e.DestIpAddr).HasColumnName("destIpAddr");

                entity.Property(e => e.DestIpv4v6Addr).HasColumnName("destIpv4v6Addr");

                entity.Property(e => e.DestLegIdentifier).HasColumnName("destLegIdentifier");

                entity.Property(e => e.DestMediaCapBandwidth).HasColumnName("destMediaCap_Bandwidth");

                entity.Property(e => e.DestMediaCapG723BitRate).HasColumnName("destMediaCap_g723BitRate");

                entity.Property(e => e.DestMediaCapMaxFramesPerPacket).HasColumnName("destMediaCap_maxFramesPerPacket");

                entity.Property(e => e.DestMediaCapPayloadCapability).HasColumnName("destMediaCap_payloadCapability");

                entity.Property(e => e.DestMediaTransportAddressIp).HasColumnName("destMediaTransportAddress_IP");

                entity.Property(e => e.DestMediaTransportAddressPort).HasColumnName("destMediaTransportAddress_Port");

                entity.Property(e => e.DestMobileCallDuration).HasColumnName("destMobileCallDuration");

                entity.Property(e => e.DestMobileDeviceName).HasColumnName("destMobileDeviceName");

                entity.Property(e => e.DestNodeId).HasColumnName("destNodeId");

                entity.Property(e => e.DestPrecedenceLevel).HasColumnName("destPrecedenceLevel");

                entity.Property(e => e.DestRsvpaudioStat).HasColumnName("destRSVPAudioStat");

                entity.Property(e => e.DestRsvpvideoStat).HasColumnName("destRSVPVideoStat");

                entity.Property(e => e.DestSpan).HasColumnName("destSpan");

                entity.Property(e => e.DestVideoCapBandwidth).HasColumnName("destVideoCap_Bandwidth");

                entity.Property(e => e.DestVideoCapBandwidthChannel2).HasColumnName("destVideoCap_Bandwidth_Channel2");

                entity.Property(e => e.DestVideoCapCodec).HasColumnName("destVideoCap_Codec");

                entity.Property(e => e.DestVideoCapCodecChannel2).HasColumnName("destVideoCap_Codec_Channel2");

                entity.Property(e => e.DestVideoCapResolution).HasColumnName("destVideoCap_Resolution");

                entity.Property(e => e.DestVideoCapResolutionChannel2).HasColumnName("destVideoCap_Resolution_Channel2");

                entity.Property(e => e.DestVideoChannelRoleChannel2).HasColumnName("destVideoChannel_Role_Channel2");

                entity.Property(e => e.DestVideoTransportAddressIp).HasColumnName("destVideoTransportAddress_IP");

                entity.Property(e => e.DestVideoTransportAddressIpChannel2).HasColumnName("destVideoTransportAddress_IP_Channel2");

                entity.Property(e => e.DestVideoTransportAddressPort).HasColumnName("destVideoTransportAddress_Port");

                entity.Property(e => e.DestVideoTransportAddressPortChannel2).HasColumnName("destVideoTransportAddress_Port_Channel2");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.FinalCalledPartyNumber)
                    .HasColumnName("finalCalledPartyNumber")
                    .HasMaxLength(64);

                entity.Property(e => e.FinalCalledPartyNumberPartition).HasColumnName("finalCalledPartyNumberPartition");

                entity.Property(e => e.FinalCalledPartyNumberUri).HasColumnName("finalCalledPartyNumber_uri");

                entity.Property(e => e.FinalCalledPartyPattern).HasColumnName("finalCalledPartyPattern");

                entity.Property(e => e.FinalCalledPartyUnicodeLoginUserId).HasColumnName("finalCalledPartyUnicodeLoginUserID");

                entity.Property(e => e.FinalMobileCalledPartyNumber).HasColumnName("finalMobileCalledPartyNumber");

                entity.Property(e => e.GlobalCallIdCallId).HasColumnName("globalCallID_callId");

                entity.Property(e => e.GlobalCallIdCallManagerId).HasColumnName("globalCallID_callManagerId");

                entity.Property(e => e.GlobalCallIdClusterId).HasColumnName("globalCallId_ClusterID");

                entity.Property(e => e.HuntPilotDn).HasColumnName("huntPilotDN");

                entity.Property(e => e.HuntPilotPartition).HasColumnName("huntPilotPartition");

                entity.Property(e => e.HuntPilotPattern).HasColumnName("huntPilotPattern");

                entity.Property(e => e.IncomingIcid).HasColumnName("IncomingICID");

                entity.Property(e => e.IncomingOrigIoi).HasColumnName("IncomingOrigIOI");

                entity.Property(e => e.IncomingProtocolId).HasColumnName("IncomingProtocolID");

                entity.Property(e => e.IncomingTermIoi).HasColumnName("IncomingTermIOI");

                entity.Property(e => e.JoinOnBehalfOf).HasColumnName("joinOnBehalfOf");

                entity.Property(e => e.LastRedirectDn).HasColumnName("lastRedirectDn");

                entity.Property(e => e.LastRedirectDnPartition).HasColumnName("lastRedirectDnPartition");

                entity.Property(e => e.LastRedirectDnUri).HasColumnName("lastRedirectDn_uri");

                entity.Property(e => e.LastRedirectRedirectOnBehalfOf).HasColumnName("lastRedirectRedirectOnBehalfOf");

                entity.Property(e => e.LastRedirectRedirectReason).HasColumnName("lastRedirectRedirectReason");

                entity.Property(e => e.LastRedirectingPartyPattern).HasColumnName("lastRedirectingPartyPattern");

                entity.Property(e => e.LastRedirectingRoutingReason).HasColumnName("lastRedirectingRoutingReason");

                entity.Property(e => e.MobileCallType).HasColumnName("mobileCallType");

                entity.Property(e => e.MobileCallingPartyNumber).HasColumnName("mobileCallingPartyNumber");

                entity.Property(e => e.OrigCallTerminationOnBehalfOf).HasColumnName("origCallTerminationOnBehalfOf");

                entity.Property(e => e.OrigCalledPartyRedirectOnBehalfOf).HasColumnName("origCalledPartyRedirectOnBehalfOf");

                entity.Property(e => e.OrigCalledPartyRedirectReason).HasColumnName("origCalledPartyRedirectReason");

                entity.Property(e => e.OrigCauseLocation).HasColumnName("origCause_location");

                entity.Property(e => e.OrigCauseValue)
                    .HasColumnName("origCause_value")
                    .HasMaxLength(64);

                entity.Property(e => e.OrigConversationId).HasColumnName("origConversationId");

                entity.Property(e => e.OrigDeviceName)
                    .HasColumnName("origDeviceName")
                    .HasMaxLength(64);

                entity.Property(e => e.OrigDtmfmethod).HasColumnName("origDTMFMethod");

                entity.Property(e => e.OrigIpAddr).HasColumnName("origIpAddr");

                entity.Property(e => e.OrigIpv4v6Addr).HasColumnName("origIpv4v6Addr");

                entity.Property(e => e.OrigLegCallIdentifier).HasColumnName("origLegCallIdentifier");

                entity.Property(e => e.OrigMediaCapBandwidth).HasColumnName("origMediaCap_Bandwidth");

                entity.Property(e => e.OrigMediaCapG723BitRate).HasColumnName("origMediaCap_g723BitRate");

                entity.Property(e => e.OrigMediaCapMaxFramesPerPacket).HasColumnName("origMediaCap_maxFramesPerPacket");

                entity.Property(e => e.OrigMediaCapPayloadCapability).HasColumnName("origMediaCap_payloadCapability");

                entity.Property(e => e.OrigMediaTransportAddressIp).HasColumnName("origMediaTransportAddress_IP");

                entity.Property(e => e.OrigMediaTransportAddressPort).HasColumnName("origMediaTransportAddress_Port");

                entity.Property(e => e.OrigMobileCallDuration).HasColumnName("origMobileCallDuration");

                entity.Property(e => e.OrigMobileDeviceName).HasColumnName("origMobileDeviceName");

                entity.Property(e => e.OrigNodeId).HasColumnName("origNodeId");

                entity.Property(e => e.OrigPrecedenceLevel).HasColumnName("origPrecedenceLevel");

                entity.Property(e => e.OrigRoutingReason).HasColumnName("origRoutingReason");

                entity.Property(e => e.OrigRsvpaudioStat).HasColumnName("origRSVPAudioStat");

                entity.Property(e => e.OrigRsvpvideoStat).HasColumnName("origRSVPVideoStat");

                entity.Property(e => e.OrigSpan).HasColumnName("origSpan");

                entity.Property(e => e.OrigVideoCapBandwidth).HasColumnName("origVideoCap_Bandwidth");

                entity.Property(e => e.OrigVideoCapBandwidthChannel2).HasColumnName("origVideoCap_Bandwidth_Channel2");

                entity.Property(e => e.OrigVideoCapCodec).HasColumnName("origVideoCap_Codec");

                entity.Property(e => e.OrigVideoCapCodecChannel2).HasColumnName("origVideoCap_Codec_Channel2");

                entity.Property(e => e.OrigVideoCapResolution).HasColumnName("origVideoCap_Resolution");

                entity.Property(e => e.OrigVideoCapResolutionChannel2).HasColumnName("origVideoCap_Resolution_Channel2");

                entity.Property(e => e.OrigVideoChannelRoleChannel2).HasColumnName("origVideoChannel_Role_Channel2");

                entity.Property(e => e.OrigVideoTransportAddressIp).HasColumnName("origVideoTransportAddress_IP");

                entity.Property(e => e.OrigVideoTransportAddressIpChannel2).HasColumnName("origVideoTransportAddress_IP_Channel2");

                entity.Property(e => e.OrigVideoTransportAddressPort).HasColumnName("origVideoTransportAddress_Port");

                entity.Property(e => e.OrigVideoTransportAddressPortChannel2).HasColumnName("origVideoTransportAddress_Port_Channel2");

                entity.Property(e => e.OriginalCalledPartyNumber)
                    .HasColumnName("originalCalledPartyNumber")
                    .HasMaxLength(64);

                entity.Property(e => e.OriginalCalledPartyNumberPartition).HasColumnName("originalCalledPartyNumberPartition");

                entity.Property(e => e.OriginalCalledPartyNumberUri).HasColumnName("originalCalledPartyNumber_uri");

                entity.Property(e => e.OriginalCalledPartyPattern).HasColumnName("originalCalledPartyPattern");

                entity.Property(e => e.OutgoingIcid).HasColumnName("OutgoingICID");

                entity.Property(e => e.OutgoingOrigIoi).HasColumnName("OutgoingOrigIOI");

                entity.Property(e => e.OutgoingProtocolId).HasColumnName("OutgoingProtocolID");

                entity.Property(e => e.OutgoingTermIoi).HasColumnName("OutgoingTermIOI");

                entity.Property(e => e.OutpulsedCalledPartyNumber).HasColumnName("outpulsedCalledPartyNumber");

                entity.Property(e => e.OutpulsedCallingPartyNumber).HasColumnName("outpulsedCallingPartyNumber");

                entity.Property(e => e.OutpulsedLastRedirectingNumber).HasColumnName("outpulsedLastRedirectingNumber");

                entity.Property(e => e.OutpulsedOriginalCalledPartyNumber).HasColumnName("outpulsedOriginalCalledPartyNumber");

                entity.Property(e => e.TotalWaitTimeInQueue).HasColumnName("totalWaitTimeInQueue");

                entity.Property(e => e.WasCallQueued).HasColumnName("wasCallQueued");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });
        }
    }
}
