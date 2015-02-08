using System.Collections.Generic;
using WcfServiceHost.Model;

namespace WcfServiceHost
{
    public static class MobileData
    {
        private static List<MobileInformation> monkeyList;

        public static List<MobileInformation> GetMobileInformation()
        {
            return
                monkeyList ??
                (
                    monkeyList =
                        new List<MobileInformation>
                        {
                             //Ty:
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Tý",
                                ScientificName = "Năm sinh: 1912, 1924, 1936, 1948, 1960, 1972, 1984, 1996, 2008, 2020. Màu mang lại may mắn: Xanh da trời, vàng, xanh lá cây. Con số may mắn: 2, 3. Loài hoa may mắn: hoa Lily, Violet",
                                CommonName = "Nhận dạng các cá nhân tuổi Tý:"
                            },
                              new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Tý",
                                ScientificName = "2015 mang lại may mắn cho các cá nhân tuổi Tý trong các mối quan hệ. Hoạt động xã hội được mở rộng, vai trò trong tập thể được củng cố, tuy nhiên điều tối quan trọng là khiêm tốn và dẹp bỏ tính ngoan cố, bướng bỉnh. Chính những tính cách được cho là điểm đặc trưng của Chuột có thể làm hỏng mối quan hệ nếu bạn không chế ngự nó. Chuyển động, thay đổi do đó chính là hai từ khóa quan trọng của năm này. Tháng 5 và tháng 8 là hai thời điểm xảy ra nhiều sự kiện trọng đại trong cuộc sống của bạn, khi bạn đưa ra các quyết định giá trị liên quan tới sự nghiệp hoặc chuyện cá nhân.",
                                CommonName = "Bảng tương hợp, tương khắc của các cá nhân tuổi Tý:"
                            },
                            new MobileInformation
                            {
                                Family ="",
                                Subfamily = "",
                                Genus = "Tý",
                                ScientificName = "Chuột là con vật đứng đầu trong mười hai con giáp, vì thế những người sinh vào năm Tý là những nhà lãnh đạo bẩm sinh. Con chuột cũng tượng trưng cho những đặc điểm tính cách như dí dỏm, sáng tạo và ham hiểu biết. Nhìn chung thì người tuổi Tý nói nhiều, quyến rũ và đầy sức sống nhưng có khuynh hướng trở nên hung hăng. Nếu bạn sinh vào những năm sau thì bạn sẽ cầm tinh con Chuột. Năm Tý: 1912, 1924, 1936, 1948, 1960, 1972, 1984, 1996, 2008 Người tuổi Tý có thể ngoan cố đi theo con đường của họ. Họ cũng có thể có tham vọng và hiểm độc, nhưng những đặc điểm đó mang lại cho họ sự gan dạ và kiên định. Người tuổi Tý sẽ không chấp nhận thất bại và luôn khao khát sự thống trị. Họ luôn kiểm soát và tìm cách để dẫn đầu trong mọi chuyện.",
                                CommonName = "Bản chất"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Tý",
                                ScientificName = "Hoạt động liên tục là điểm mạnh, nhưng đồng thời cũng là điểm yếu của các cá nhân tuổi Chuột, bạn không cho mình đủ thời gian để nghỉ ngơi. Các bệnh liên quan tới thận, tim mạch… có thể gây cho bạn sự mệt mỏi, cần chú ý tập luyện, chăm sóc sức khỏe nhiều hơn. Nếu điều gì đó khiến bạn đau đầu, hãy lấy lại sự khuây khỏa bằng việc đi du lịch. Nói chung là người tuổi Tý có sức khỏe tốt. Nhờ sự năng động của mình mà họ có được thân hình đẹp và khả năng chống chọi với bệnh tật. Một điều mà họ dễ mắc phải là bị căng thẳng do làm căng vấn đề, hung hăng và bị kích động. Người tuổi Tý nên chú ý đến những bài tập nhằm giúp họ giữ bình tĩnh vì lợi ích lâu dài.",
                                CommonName = "Sức Khỏe"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                 Genus = "Tý",
                                ScientificName = "Đây dường như không phải là năm nhiều may mắn trong đường công danh, tài lộc của các cá nhân tuổi Tý, nhưng thực tế, điều này giúp bạn không phải chịu đựng những áp lực lớn từ công việc và có nhiều thời gian hơn cho gia đình, bạn bè. Quan trọng hơn cả, bạn có sự giúp đỡ của mọi người khi đối mặt với những thách thức hay yêu cầu từ cấp trên, khách hàng… Cộng với sự nhanh nhạy, khôn khéo nổi tiếng, Chuột sẽ xử trí ổn thỏa mọi chướng ngại vật trên đường. Yếu tố Lửa mang ý nghĩa về tài chính, vì vậy, năm 2015 này có liên quan nhiều tới tài chính, các hoạt động của bạn chủ yếu xoay quanh đồng tiền. Nhờ lời khuyên sáng suốt của ai đó, vào một thời điểm nhất định trong năm, bạn có được cơ hội đầu tư, mua bán phù hợp và đạt được những kết quả ngoài mong đợi. Tuy nhiên, một nhắc nhở cho bạn là không nên ham mê đầu tư mạo hiểm, bởi đồng tiền có được do may mắn thường không bền. Một thời điểm nào đó, nếu bạn có cơ hội làm công việc mình ưng ý, hãy nắm lấy nó, đừng ngại ngần thay đổi. Sự đứng yên một chỗ chính là điều tồi tệ nhất trong năm này. Với cương vị mới, hãy tự tin thể hiện năng lực thay vì e ngại bất cứ điều gì. Người tuổi Tý tinh ý và khôn ngoan một cách đặc biệt. Điều này giúp họ tập trung vào công việc to lớn. Khả năng này đi kèm với óc phán đoán tốt cho phép họ giải quyết vấn đề trước khi nó nảy sinh. Họ cũng luôn bị thúc đẩy bởi địa vị, tiền bạc và tập trung vào danh vọng trên con đường sự nghiệp của họ. Cùng một thời điểm, họ cần nhiều vị trí linh động cho phép họ sáng tạo vì những công việc thường nhật sẽ làm thui chột khả năng sáng tạo của họ.",
                                CommonName = "Sự nghiệp và tài chính"
                            },
                             new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                 Genus = "Tý",
                                ScientificName = "Sự xung khắc của Thủy và Hỏa khiến cho chuyện tình cảm của Chuột không thuận lợi. Đây không phải năm để xây dựng các mối quan hệ yêu đương, hoặc bạn phải bỏ không ít thời gian nếu muốn tìm kiếm một đối tác phù hợp. Mâu thuẫn, tranh cãi sẽ thường xuyên xảy đến giữa hai người nếu không biết thận trọng trong lời ăn, tiếng nói và tính toán thận trọng trước khi hành động. Nhiều thời điểm trong năm, Chuột rơi vào trạng thái cô đơn, nhưng chính ở thời điểm này, bạn tập trung vào điều quan trọng nhất: bản thân mình. Với những bạn đã có một nửa, để gìn giữ mối quan hệ này, bạn cần bắt tay với những thay đổi tích cực mang tính cải thiện tình cảm, nếu không, hai người sẽ dễ tan vỡ. Người tuổi Tý sử dụng sự quyến rũ của mình khi họ tham gia những hoạt động xã hội và có xu hướng luôn muốn gặp gỡ những người mới chính vì điều này. Lối ứng xử thông minh và lôi cuốn khiến mọi người vây quanh họ. Có một nhược điểm là người tuổi Tý không giỏi trong việc chấm dứt những mối quan hệ và điều này ngăn cản họ tiến tới một mối quan hệ mới.",
                                CommonName = "Tình duyên"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Tý",
                                ScientificName = "TTrong việc chọn bạn bè, hãy tỉnh táo, sáng suốt để tìm ra ai là người thực sự tốt với mình, đừng đặt niềm tin nhầm chỗ. Các tuổi hợp với Chuột năm nay là Thân, Thìn, Sửu và Mão. Ngược lại, các tuổi khắc là Mùi và Ngọ.",
                                CommonName = "Hợp tuổi"
                            },

                             //Suu:
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Sửu",
                                ScientificName = "Năm sinh: 1913, 1925, 1937, 1949, 1961, 1973, 1985, 1997, 2009, 2021 Màu mang lại may mắn: Xanh da trời, vàng, xanh lá cây. Con số may mắn: 1, 4 Loài hoa may mắn: Tulip, thủy tiên",
                                CommonName = "Nhận dạng các cá nhân tuổi Sửu:"
                            },
                              new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Sửu",
                                ScientificName = "Không gặp nhiều vướng mắc, trở ngại, cộng với tính cách cần cù, nhẫn nại và đáng tin cậy, Trâu có thể đạt tới những thành công giá trị trong năm Ất Mùi. Hướng tới lối sống đơn giản, Trâu ít khi làm phức tạp hóa vấn đề và luôn giữ cho mình cái đầu thanh thản. Đây được coi là thế mạnh, nhưng đôi khi lại trở thành điểm yếu bởi họ ngại thay đổi, đôi khi tỏ ra cố chấp dù hiểu rằng mình sai sót. Một khía cạnh khác cần chú ý, đó là lòng trung thành-đức tính nổi bật của Trâu, việc đặt niềm tin sai chỗ có thể sẽ khiến bạn phải thất vọng. Đây cũng là năm để Sửu vác balo lên đường trải nghiệm, những hành trình du lịch thú vị không chỉ mang lại cho bạn kiến thức mà còn cả may mắn trong tình bạn, tình yêu. Năm 2015 cũng cho bạn cơ hội bày tỏ những ý tưởng, quan điểm của mình một cách tự tin, mạnh mẽ trước tập thể. Vận dụng trí tưởng tượng, sự sáng tạo là cách để biến mơ ước thành hiện thực. Ở thời điểm giữa năm, bạn có thể gặp một vài khó khăn trong việc ổn định sự nghiệp, nhưng qua những thời khắc này, tất cả sẽ lại ổn thỏa. May mắn đồng hành, nhưng đừng để sự nóng nảy nhất thời khiến bạn làm mất đi cơ hội. Các tuổi hợp với Sửu năm 2015 là: Tý, Mão, Thân. Ngược lại, các tuổi khắc là: Thìn và Ngọ, Mùi.",
                                CommonName = "Bảng tương hợp, tương khắc của các cá nhân tuổi Tý:"
                            },
                            new MobileInformation
                            {
                                Family ="",
                                Subfamily = "",
                                Genus = "Sửu",
                                ScientificName = "Trâu là con vật đứng thứ hai trong mười hai con giáp, và cũng giống như những người tuổi Tý, những người sinh vào năm Sửu thường có những tính cách mạnh mẽ và nổi trội. Họ là những người có lập trường kiên định và luôn tin rằng con đường đến với thành công là làm việc chăm chỉ. Người tuổi Sửu có tính cách bền bỉ và sự cố gắng nhằm mang lại sự sung túc, ổn định cho bản thân và gia đình. Hãy tưởng tượng cảnh một con Trâu đang cày bừa trên đồng, bạn sẽ có một cái nhìn rõ ràng về người tuổi Sửu. Chậm chạp và kiên định với sức mạnh ấn tượng, điều này làm tăng thêm sự khâm phục dành cho con Trâu. Đó là lý do vì sao con Trâu là biểu tượng cho sự nhẫn nại và kiên trì. Nếu bạn sinh vào những năm sau đây thì bạn sẽ cầm tinh con Trâu. Năm Sửu: 1913, 1925, 1937, 1949, 1961, 1973, 1985, 1997, 2009",
                                CommonName = "Bản chất"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Sửu",
                                ScientificName = "Nói chung là người tuổi Sửu là những người mạnh mẽ và có sức khỏe tốt nên sẽ sống thọ. Tuy nhiên, điều đó còn tùy thuộc vào sự cố gắng để đạt được thành công của họ. Họ thường có xu hướng làm việc quá nhiều và không cho phép mình nghỉ ngơi. Vì thế, người tuổi Sửu nên tận dụng cơ hội tham gia vào những hoạt động không liên quan đến công việc để làm giảm bớt căng thẳng trong công việc. Chăm chỉ đến hết mình với công việc, Trâu có thể quên chăm sóc sức khỏe. Hãy quan tâm nhiều hơn đến bản thân bằng cách tập luyện, ăn uống hợp lý, cân bằng giữa công việc với cuộc sống riêng tư, đây là cách hiệu quả để tránh bệnh tật.",
                                CommonName = "Sức Khỏe"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                 Genus = "Sửu",
                                ScientificName = "Người tuổi Sửu thường làm việc hiệu quả và bền bỉ để đạt được mục tiêu của mình. Họ yêu thích công việc có tính lặp đi lặp lại và sẽ tuân thủ đúng theo những bước đã được đề ra. Họ cũng chú ý đến những chi tiết nhỏ nhặt và có tác phong làm việc bền bỉ, hy sinh quên mình. Người tuổi Sửu có xu hướng làm việc hiệu quả hơn nếu họ được phép làm việc một mình. Có năng lực cộng với sự may mắn, Trâu có một năm làm ăn thuận lợi. Nhận được nhiều sự quan tâm, bảo trợ, sự đánh giá tốt của cấp trên, bạn có cơ hội sự nghiệp rộng mở. Tuy nhiên, hãy thận trọng khi đứng trước tiền bạc, nếu không, bạn sẽ bị ảnh hưởng xấu hoặc rắc rối với luật pháp. Ngoài ra, tính ngoan cố có thể khiến bạn không đưa ra được những quyết định đúng thời điểm, dẫn đến đánh mất cơ hội. Giữ một tinh thần cởi mở, mềm dẻo, bạn sẽ thành công. Tư chất chịu khó, quyết tâm và không than phiền giúp Trâu có thể được cất nhắc vai trò quản lý, lãnh đạo. Nếu bạn nghĩ đến tìm công việc mới, đây cũng là thời điểm phù hợp. Tuy vậy, điều quan trọng nhất với bạn trong năm nay chính là tiết chế năng lượng cho phù hợp, tránh làm việc “hùng hục” ở những thời điểm không cần thiết. Nếu bạn tính đến việc mua nhà cửa, đây cũng là năm thích hợp.",
                                CommonName = "Sự nghiệp và tài chính"
                            },
                             new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                 Genus = "Sửu",
                                ScientificName = "Trâu tạo sức hút bởi sự trung thành, chăm chỉ. Là người đáng tin cậy, bạn chính là chỗ dựa cho đối tác của mình. Tuy nhiên, sự “thô ráp” vô tình khiến bạn đôi khi hơi buồn tẻ, đơn điệu trong mắt bạn đời. Nỗ lực để “thêm gia vị” cho đời sống tình cảm vô cùng quan trọng. Nếu bạn yêu ai đó, đừng giấu giếm tình cảm trong lòng, hãy thẳng thắn nói ra, và người ấy sẽ cho bạn cơ hội. Đối với những bạn đang tìm kiếm một nửa, tháng giêng, tháng sáu, tháng tám và đặc biệt tháng chín là thời điểm phù hợp. Năm 2015 là năm nhiều thuận lợi trong chuyện tình cảm của các cá nhân tuổi Sửu. Khi phát hiện ra đối tượng ưng ý, Trâu sẽ không bỏ lỡ cơ hội, và may mắn là thành công sẽ mỉm cười với bạn. Mối quan hệ chuyển sang một giai đoạn mới, tình yêu “đâm chồi nảy lộc”, mang lại cho bạn sự hạnh phúc. Một lời khuyên khác cho bạn: đừng để người thứ ba tác động tới mối quan hệ. Sự ghen tuông mù quáng khiến bạn rơi vào tình trạng kiểm soát “một nửa” quá chặt chẽ, khiến mối quan hệ ngột ngạt. Những thời điểm bận rộn trong năm, bạn có thể quên dành thời gian chăm sóc bạn đời (người yêu), khiến họ cô đơn. Người tuổi Sửu không thể hòa hợp được với môi trường đội nhóm. Họ không hòa đồng và hiếm khi tham gia vào những hoạt động nhóm. Và khi đang tiếp xúc với ai đó, họ cũng không thích nói chuyện phiếm và cũng không phí thời gian để tán tỉnh người khác. Một khi đã tìm được một nửa của mình, họ sẽ cống hiến hết mình cho cuộc sống và điều đó giúp họ trở thành những người bạn đời chung thủy. Thật không may là vì người tuổi Sửu có xu hướng chỉ đạo, ngạo mạn và đổ lỗi cho người khác, nên những mối quan hệ của họ có thể bị dao động. Họ phải hiểu rằng một mối quan hệ đòi hỏi phải có hai người và hai quan điểm. Và khi hiểu được điều đó, một mối quan hệ tốt đẹp là điều hoàn toàn có thể.",
                                CommonName = "Tình duyên"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Sửu",
                                ScientificName = "TTrong việc chọn bạn bè, hãy tỉnh táo, sáng suốt để tìm ra ai là người thực sự tốt với mình, đừng đặt niềm tin nhầm chỗ. Các tuổi hợp với Chuột năm nay là Thân, Thìn, Sửu và Mão. Ngược lại, các tuổi khắc là Mùi và Ngọ.",
                                CommonName = "Hợp tuổi"
                            },

                               //Dần:
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Dần",
                                ScientificName = "Năm sinh: 1914, 1926, 1938, 1950, 1962, 1974, 1986, 1998, 2010, 2022 Màu may mắn: Xám, Trắng, Cam. Số may mắn: 3,4",
                                CommonName = "Nhận dạng các cá nhân tuổi Dần:"
                            },
                              new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Dần",
                                ScientificName = "Theo quan niệm dân gian, Hổ là chúa tể muôn loài. Đầy uy quyền, sức mạnh và sự dũng cảm, Hổ khiến ai ai cũng nể phục, thậm chí là sợ hãi. Trên thực tế, tuổi Hổ được mọi người tin cậy và giao phó những trọng trách lớn. Tuy nhiên, điểm yếu của họ là sự nóng nảy, đôi khi độc đoán, chuyên quyền. Năm 2015 thực sự là năm nhiều thách thức nhưng cũng rất thú vị với những cá nhân tuổi Dần. Luôn hướng tới địa vị và hài lòng khi được trọng vọng, bạn không ngại khi được giao những vị trí trọng trách, thậm chí thể hiện rất tốt ở cương vị này. Dù vậy, theo quan niệm của người Trung Quốc, tuổi Tỵ và Dần rất xung khắc, và vì thế, đối với năm Ất Mùi, bạn buộc phải đề phòng những hiểm nguy bất ngờ rình rập, những kẻ thù giấu mặt có thể khiến sự nghiệp của bạn gặp trở ngại. Nỗ lực duy trì mối quan hệ với đồng nghiệp, tránh điều tiếng xấu là những việc làm cần thiết. Nhìn chung, 2015 diễn ra tốt đẹp hay trắc trở hoàn toàn phụ thuộc vào cách bạn thể hiện sức mạnh, hạn chế điểm yếu. Sự bốc đồng có thể khiến bạn đưa ra những quyết định thiếu sáng suốt, thậm chí là phải trả một cái giá không nhỏ. Trước khi hành động, đừng quên cho mình thời gian để cân nhắc thiệt, hơn. Đây là một năm bận rộn với việc công nhiều hơn tư, các hoạt động xã hội cuốn bạn đi với một guồng quay mạnh mẽ. Tuy nhiên, tháng sáu, tất cả sẽ trở lại với nhịp độ ổn định. Trong những tháng mùa hè, bạn có cơ hội gặp gỡ, giao lưu với những người bạn mới đầy thú vị.",
                                CommonName = "Bảng tương hợp, tương khắc của các cá nhân tuổi Dần:"
                            },
                            new MobileInformation
                            {
                                Family ="",
                                Subfamily = "",
                                Genus = "Dần",
                                ScientificName = "Hổ là con vật đứng thứ ba trong mười hai con giáp. Con Hổ đại diện cho các tính cách như dũng cảm, thích ganh đua, và hay thay đổi. Họ sẽ đương đầu với bất kỳ khó khăn thử thách nào ở phía trước, đặc biệt là khi cần phải bảo vệ người mà mình yêu quý hoặc kính trọng. Những người sinh vào năm Dần có bề ngoài hiền lành. Nhưng bạn đừng để điều đó đánh lừa, vì một con Hổ sẽ vùng dậy khi thấy cần thiết. Vốn được sinh ra để lãnh đạo nên những người sinh năm Dần luôn muốn kiểm soát mọi thứ và họ sẽ ương bướng ngang ngạnh nếu không được làm người đứng đầu. Người tuổi Dần thường thông minh và có sức cuốn hút khiến họ luôn được mọi người yêu mến. Ít có con vật nào vừa có tình nghĩa và chu đáo, lại vừa lắm mưu mô và khó lường, mà cũng thành thật như con Hổ. Những người sinh vào năm Dần có thể hùng hổ và luôn thích thử thách, nhưng họ cũng có thể rất hòa đồng và trung thành, và điều này giúp họ trở thành một đồng minh tuyệt vời. Nếu bạn sinh vào các năm dưới đây thì năm tuổi của bạn là năm Dần. Năm Dần : 1914, 1926, 1938, 1950, 1962, 1974, 1986, 1998, 2010",
                                CommonName = "Bản chất"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Dần",
                                ScientificName = "Tâm trạng không tốt có thể gây ảnh hưởng tới tính khí của bạn. Sự trục trặc trong chuyện tình cảm gây cho bạn sự chán nản, thất vọng. Dành nhiều thời gian hơn để thư giãn, đi du lịch, đi leo núi… để lấy lại cân bằng. Hạn chế thăm viếng đám hiếu. Do bản chất và xu hướng thích đương đầu với thử thách nên những người sinh năm Dần thường bị kiệt sức. Mặc dù họ có thể hồi phục, nhưng theo thời gian, điều này sẽ khiến họ gặp vấn đề về sức khỏe. Những người này cần phải tìm hiểu và phát triển lối tiếp cận cuộc sống một cách cân bằng hơn và sử dụng năng lượng của mình một cách hợp lý hơn.",
                                CommonName = "Sức Khỏe"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                 Genus = "Dần",
                                ScientificName = "Người tuổi Hổ không bận tâm quá nhiều tới tài chính của mình. Họ yêu quyền lực và thường cho rằng tiền bạc tỷ lệ thuận với vị thế (dù sự thật đôi khi không phải vậy). Điểm yếu này thể hiện ở chỗ, đôi khi bạn chi tiêu mà không tính toán đến thu nhập, dẫn đến tình trạng hầu bao có thể cạn kiệt bất ngờ. Hơn thế nữa, dù 2015 là một năm nhiều bận rộn, tài chính không được cải thiện đáng kể. Vì vậy, vạch ra cho mình một kế hoạch tiêu dùng từ ngay đầu năm và tuân thủ nó, bạn sẽ có một năm tài chính ổn định. Đây cũng là năm bạn gặp những bất đồng về ý tưởng hay cách xử lý công việc với đồng nghiệp. Bạn có thể hướng đến giải pháp từ bỏ nếu vị trí ấy không phù hợp với mình. Với năng lực cá nhân, bạn hoàn toàn có khả năng tìm kiếm một công việc mới. Đương nhiên điều này không có nghĩa rằng bạn quay lưng lại với sự thỏa hiệp, nhưng nếu bạn thấy rằng mình không được đánh giá đúng mực, hãy mạnh dạn chuyển hướng. Những thay đổi hoặc khởi đầu mới mẻ có thể mang lại thành công. Đặc biệt, bạn còn có thể tiến xa hơn nếu gạt bỏ sự tự ái để tìm đến những lời khuyên từ chuyên gia hay đơn giản hơn là những người đi trước. Những người tuổi Dần thường hướng đến thử thách và vì thế họ hay chuyển đổi công việc để tìm cái mới. Có vẻ như đây là một khó khăn, nhưng không là vấn đề đối với người sinh năm Dần vì họ thông minh và có thể thích ứng với vị trí mới một cách nhanh chóng. Loại nghề nghiệp nào giúp người ta tiến được đến vị trí lãnh đạo sẽ phù hợp với họ.",
                                CommonName = "Sự nghiệp và tài chính"
                            },
                             new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                 Genus = "Dần",
                                ScientificName = "Sức mạnh của Hổ là thỏi nam châm hút mọi người đến gần hơn với bạn. Là bạn tình nồng nàn, mạnh mẽ, Hổ mang đến những cảm xúc đẹp đẽ cho đối phương. Bạn chỉ gặp rắc rối khi đánh mất niềm tin vào bản thân. Có thể trong mắt ai đó, bạn quá nóng nảy, độc đoán, nhưng đây không phải vấn đề của bạn, mà là ở họ. Đừng cố gắng thay đổi chỉ để làm hài lòng người ấy, bạn sẽ không giữ được họ mãi mãi bên mình. Chìa khóa cho chuyện tình cảm của Hổ trong năm 2015 này là dành tình yêu cho người xứng đáng. Năm 2015 cũng mang đến những may mắn trong các mối quan hệ tình cảm đã có, tuy nhiên, nếu bạn “đứng núi này trông núi nọ”, bạn sẽ mất “cả chì lẫn chài”. Người tuổi Dần rất nồng nàn và không bao giờ làm phiền lòng bạn đời của mình. Họ là người tình cảm, lịch thiệp và đáng tin cậy. Tuy nhiên, bạn cần ý thức được rằng người sinh năm Dần luôn có xu hướng muốn nắm quyền điều khiển trong các mối quan hệ của họ. Là bạn đời hoặc người yêu của họ cũng cần phải dồi dào năng lượng để bắt nhịp với chiều hướng mạo hiểm của họ.",
                                CommonName = "Tình duyên"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Dần",
                                ScientificName = "Tuổi Dần hạp với tuổi Ngọ, tuổi Tuất, tuổi Hợi.",
                                CommonName = "Hợp tuổi"
                            },

                                //Mão
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Mão",
                                ScientificName = "Năm sinh: 1915, 1927, 1939, 1951, 1963, 1975, 1987, 1999, 2011, 2023 Màu may mắn: Đỏ, hồng, tím. Số may mắn: 3, 9",
                                CommonName = "Nhận dạng các cá nhân tuổi Mão:"
                            },
                              new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Mão",
                                ScientificName = "Đứng thứ tư trong 12 con giáp, tuổi Mão đại diện cho những cá nhân có lối sống kín đáo. Được yêu mến bởi tính cách nền nã, nhẫn nại, tuổi Mèo tạo cho đối phương cảm giác tin cậy. Khi gặp vấn đề rắc rối, họ không dễ buông xuôi, chán nản mà kiên trì tìm giải pháp, điều này giải thích vì sao Mèo hay đạt được thành công trên đường công danh, sự nghiệp. Hơn thế nữa, họ còn là những cá nhân xuất sắc trong nghệ thuật và gây ấn tượng cho mọi người. Sống trầm tĩnh, tuổi Mão ít khi bộc bạch tâm tư, thậm chí có xu hướng lẩn trốn thực tại. Mặt tiêu cực, họ sống thủ cựu, thận trọng quá mức và không ít lần bỏ lỡ cơ hội của mình. Vì vậy, 2015 sẽ nhiều thành công nếu bạn giảm độ ì, năng nổ hơn trong công việc. Những hành động của bạn trong 2015 không chỉ có ảnh hưởng tới cả năm này, mà còn là tương lai phía trước.Đây là năm mà tuổi Mão hào hứng được chuyển động và bắt tay với những cái mới. Chìa khóa cho năm này là tìm ra đáp án cho câu hỏi: Tại sao bạn muốn điều này, điều kia, chứ không đơn thuần là liệt kê những gì bạn mong mỏi. Ví dụ, nếu bạn có ý định thay đổi công việc, hãy tự hỏi mình vì sao, và nếu câu trả lời là xác đáng, bạn nên gạt lo âu để tiến bước. Ngược lại, nếu đó chỉ là sự mệt mỏi, chán nản nhất thời, hãy điềm tĩnh lại và cho mình thời gian nghỉ ngơi, thư giãn, thay vì “đứng núi này trông núi nọ”. Trên thực tế, khả năng cân bằng giữa các khía cạnh tình cảm, công việc, sự nghiệp… giúp đảm bảo cho bạn có một năm dễ chịu. Ngoài ra, sự thiếu tập trung vào các chi tiết nhỏ nhặt có thể khiến cho bạn bỏ qua cơ hội cũng như thiếu chú ý tới những rắc rối tiềm tàng. Ỷ lại ở sự không ngoan của mình, đôi khi bạn tự tin quá mức và đặt ra những cái mốc quá tầm với. Chính điều này gây ra cho bạn sự hụt hẫng khi mọi việc không được như ý. Mèo luôn nhìn Rắn bằng con mắt hiếu kỳ, vì thế, Ất Mùi hứa hẹn sẽ là năm để các cá nhân tuổi Mão bận rộn khám phá và đưa ra các ý tưởng sáng tạo. Tuy vậy, việc Rắn tìm cách lẩn trốn khi có sự xuất hiện của Mèo cũng là dấu hiệu cho một năm không mấy đủ đầy trong chuyện tình cảm.",
                                CommonName = "Bảng tương hợp, tương khắc của các cá nhân tuổi Mão:"
                            },
                            new MobileInformation
                            {
                                Family ="",
                                Subfamily = "",
                                Genus = "Mão",
                                ScientificName = "Mèo là con vật đứng thứ tư trong mười hai con giáp. Mèo tượng trưng cho lòng tốt, sự nhạy cảm và dịu dàng. Những người tuổi Mão cũng rất hiếu khách và thích giúp đỡ người khác – đây là đặc tính tự nhiên, vì họ không thích những tình huống khó lường trước. Tuy nhiên, lòng tốt và sự nhiệt tình giúp đỡ của họ thường dễ bị người khác lợi dụng. Thái độ hòa hoãn và dễ chịu của những người tuổi Mão là một sự thay đổi so với ba cung tuổi đầu tiên. Nhưng, thái độ đó, lại một lần nữa, khiến họ dễ bị xúc phạm và lợi dụng. Những người tuổi Mão là những tạo vật hết sức mong manh và có thể trở nên bối rối khi mọi thứ bị xáo trộn. Họ cũng thường có xu hướng cẩn trọng và bảo thủ – đây là điều khiến họ bỏ lỡ nhiều cơ hội trong cuộc sống. Tuy nhiên, bù lại việc thiếu sự hùng hổ và quyền lực thì người tuổi Mão có một trái tim nhân hậu và tâm hồn bình an giúp họ trở thành những người bạn tuyệt vời nhất. Nếu bạn sinh vào các năm dưới đây thì năm tuổi của bạn là năm Mão. Năm Mão : 1915, 1927, 1939, 1951, 1963, 1975, 1987, 1999, 2011",
                                CommonName = "Bản chất"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Mão",
                                ScientificName = "Đây là năm mà sức khỏe của bạn ở mức trung bình. Trong khoảng thời gian đầu năm, bạn cần quan tâm, chăm sóc tới bản thân nhiều hơn: tập luyện thể dục thể thao, ăn uống hợp lý, uống nước đầy đủ… nhằm phòng tránh bệnh tật. Những âu lo có thể khiến bạn stress, mất ngủ và đau ốm. Tìm đến bạn bè để được chia sẻ, bạn sẽ sớm lấy lại thăng bằng. Ngoài ra, công việc vất vả có thể khiến sức lực bạn hao mòn, tâm trí uể oải. Hãy dành nhiều thời gian hơn để thư giãn và tránh tối đa phiền toái. Học cách nói “Không” đúng thời điểm để giảm bớt công việc và dành thời gian cho bản thân mình.",
                                CommonName = "Sức Khỏe"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                 Genus = "Mão",
                                ScientificName = "Đây không phải một năm xuất sắc trong lĩnh vực tài chính, sự nghiệp của các cá nhân tuổi Mão, dù bạn lúc nào cũng bận rộn. Những quyết định thiếu tính toán, sự dễ dãi trong việc cho vay mượn có thể khiến bạn bị thất thoát tiền bạc. Khoảng thời gian đầu năm, một vài chướng ngại vật xuất hiện trên đường công danh, sự nghiệp, nhưng đừng vội buông xuôi mà đánh mất cơ hội của mình. Không có được những may mắn bất ngờ về tiền bạc, bạn phải đổ nhiều mồ hôi, công sức để có thể điền đầy hầu bao. Đừng dại thử vận với những trò may rủi, kết quả sẽ không được như ý. Ngoài ra, bạn cũng không nên hy vọng quá nhiều vào sự trợ giúp của bạn bè, đồng nghiệp, nếu muốn điều gì đó, hãy tự mình đạt được nó thay vì phàn nàn, bất mãn. Quan điểm tiêu cực có thể gây ảnh hưởng tới vị trí công việc của bạn. Hãy khéo léo hơn trong hành xử với đồng nghiệp, đặc biệt là cấp trên nếu bạn muốn đường công danh hanh thông. Nếu bạn là thương gia, cần quan tâm nhiều hơn tới chăm sóc khách hàng. Là người giàu tham vọng, có tài năng và ăn nói lưu loát, người tuổi Mão có rất nhiều cơ hội nghề nghiệp. Họ cũng có lòng trắc ẩn có thể giúp họ thành công trong các công việc như nhà trị liệu, bác sĩ hay nghệ sĩ. Những người tuổi Mão cũng có khả năng kinh doanh và giao tiếp tuyệt vời.",
                                CommonName = "Sự nghiệp và tài chính"
                            },
                             new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                 Genus = "Mão",
                                ScientificName = "Bằng sự khéo léo của mình, tuổi Mão không khó khăn để tìm kiếm đồng minh, thậm chí biến thù thành bạn. Sự tốt bụng, chân thành giúp họ đến gần hơn với mọi người. Dù vậy, lối sống kín đáo, đôi khi thận trọng của bạn có thể khiến người khác e dè. Đây là năm mà bạn nên chia sẻ, tâm tình nhiều hơn để được ủng hộ và giúp đỡ. Một số thời gian trong năm, thái độ thiếu thân thiện của những người thân thiết có thể khiến Mèo ngã lòng, chán nản, tuy nhiên nếu kiên trì vượt qua giai đoạn này, bạn sẽ lấy lại hình ảnh trong lòng họ. Tăng cường thắt chặt các mối quan hệ, không ngừng bày tỏ sự quan tâm tới gia đình, bạn bè là cách để xích lại gần nhau. Dành nhiều thời gian hơn cho gia đình, đặc biệt trong khoảng tháng 9 và tháng 11. Năm 2015 này, xây dựng tổ ấm hoặc khởi đầu các mối quan hệ mới là mong muốn của không ít cá nhân tuổi Mão. Tuy nhiên, trước những bước ngoặt quan trọng của cuộc đời, hãy cho mình thời gian suy nghĩ và cân nhắc một cách thật tỉnh táo, đừng để bất cứ lý do gì hối thúc bạn. Đối với những cá nhân còn đang đơn lẻ, chớ nên vội vàng tìm kiếm “đối tác” – thưởng thức cuộc sống tự do cũng mang đến những ý nghĩa thú vị. Ất Mùi không mang lại nhiều may mắn trong chuyện tình cảm cho các cá nhân tuổi Mão. Với người đã lập gia đình, bạn có thể trải qua cảm giác cô đơn khi không tìm được tiếng nói chung với đối tác, lý do xuất phát từ nhiều yếu tố: tiền bạc, sức khỏe… Một chuyến du lịch có thể giúp hai bên hàn gắn tình cảm. Thoải mái và đầy quyến rũ, người tuổi Mão không phải là kẻ vụ lợi trong các mối quan hệ. Vì thế chẳng có gì ngạc nhiên khi họ là những người yêu, bạn đời tuyệt vời. Tuy nhiên, những người sinh năm Mão cần tìm người yêu hoặc bạn đời có thể trân trọng bản chất không vụ lợi của họ cũng như tạo dựng một mối quan hệ đầy cảm thông, thương yêu và bình yên.",
                                CommonName = "Tình duyên"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Mão",
                                ScientificName = "Người tuổi Mão hợp người tuổi Mùi, tuổi Hợi và tuổi Tuất.",
                                CommonName = "Hợp tuổi"
                            },

                                //Thìn
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Mão",
                                ScientificName = "Năm sinh: 1916, 1928, 1940, 1952, 1964, 1976, 1988, 2000, 2012, 2024 Màu may mắn: vàng, bạc, trắng xám Con số may mắn: 1,6,7",
                                CommonName = "Nhận dạng các cá nhân tuổi Thìn:"
                            },
                              new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Thìn",
                                ScientificName = "Vị trí thứ năm trong bảng 12 con giáp được dành cho các cá nhân tuổi Thìn. Với tính cách dũng cảm, mạnh mẽ nhưng cũng rất nhạy cảm, họ dễ được lòng mọi người và được họ nể vì. Là những con người tham vọng, Rồng luôn nỗ lực để đạt tới cái đích mình vạch ra, thậm chí bằng cả sự mạo hiểm. Say mê công việc, họ dễ đạt được thành công, tuy nhiên lại thường rơi vào trạng thái mệt mỏi, kiệt sức. Mặc dù rất được yêu thích nhưng Rồng thường hướng tới cuộc sống tự do hoặc cảm thấy cô đơn ngay cả trong đám đông. Là người thủ lĩnh đích thực, họ muốn được nắm quyền hành thay vì để ai đó sai khiến mình. Yêu thích công việc sáng tạo, Rồng tỏa sáng với bai trò nhà đầu tư, nhà thiết kế, luật sư… Nếu năm 2012 không mang lại nhiều may mắn, phúc lộc cho các cá nhân tuổi Thìn thì 2015 này, tình hình sẽ khởi sắc, đặc biệt với những người làm trong ngành truyền thông, nghệ thuật… Nhờ quý nhân phù trợ cộng với sự giúp đỡ của bạn bè, Rồng có được những thuận lợi trong công việc và tránh được những hiểm họa rình rập. Ngoài ra, những cơ hội công tác nước ngoài có thể giúp bạn thể hiện rõ năng lực của mình trong tập thể. Dù vậy, bạn cũng cần thận trọng trong lời ăn tiếng nói, đừng để vướng vào những tin đồn thất thiệt. Những thành tựu bạn đạt được trong năm có thể khiến ai đó ghen tị, nhưng nên cư xử với họ bằng thái độ ôn hòa, cởi mở nhằm tránh những hiểu nhầm không đáng có. Trong năm, sự tập trung cao độ trong công việc cũng giúp bạn hoàn thành mục tiêu sự nghiệp. Liên quan tới tài chính, tuổi Thìn có thể gặp mất mát tiền bạc trong năm này nếu không biết tính toán thận trọng. Có khả năng kiếm tiền nhưng coi đó không phải mục tiêu duy nhất trong đời sống, bạn đôi khi bỏ qua cơ hội của mình. Cân nhắc đầu tư phù hợp, kiên nhẫn chờ đợi kết quả thay vì “gặt lúa non”. Nếu có thể, đặt một bức tượng Phật trong nhà sẽ giúp mang lại an hòa cho cuộc sống. Một vài thời điểm trong năm, sự hỗ trợ thầm lặng của ai đó giúp bạn thu về những thành công nho nhỏ. Tuổi Thìn hợp với Tí, Dậu, Thân và khắc với Dần, Tuất, Sửu.",
                                CommonName = "Bảng tương hợp, tương khắc của các cá nhân tuổi Thìn:"
                            },
                            new MobileInformation
                            {
                                Family ="",
                                Subfamily = "",
                                Genus = "Thìn",
                                ScientificName = "Con Rồng là con vật hùng mạnh và được kính trọng nhất trong số mười hai con giáp. Nó tượng trưng cho tham vọng và thống trị, nhưng đồng thời nó cũng là con vật linh thiêng và mang tính thần thánh.Người sinh vào năm Thìn tràn đầy năng lượng và sức mạnh, có sức quyến rũ và tỏa sáng, và là biểu tượng của sự giàu có và quyền lực. Không ngại thử thách và sẵn sàng dấn thân vào mạo hiểm là phần cốt lõi trong những điều làm cho người tuổi Thìn trở nên đặc biệt.Họ thích sống theo nguyên tắc của chính mình và muốn được ở một mình. Đó là một người đặc biệt, thực sự thiêng liêng và thần thánh.Nếu bạn sinh vào những năm dưới đây thì bạn tuổi Thìn.Năm Thìn: 1916, 1928, 1940, 1952, 1964, 1976, 1988, 2000",
                                CommonName = "Bản chất"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Thìn",
                                ScientificName = "Sức khỏe tuổi Thìn 2015 này khá ổn định, bạn không gặp vấn đề lớn nào khiến tâm trí phải nặng ưu tư. Đây cũng là năm để nạp năng lượng, hãy dành nhiều thời gian hơn để thư giãn, nghỉ ngơi và tham gia các hoạt động xã hội. Một vài thời điểm trong năm, sao xấu có thể gây tổn hại tới danh dự, sức khỏe của bạn, nhưng duy trì sự cân bằng là chìa khóa giúp bạn an lành.Nhìn chung, người tuổi Thìn có sức khỏe tốt, cho dù bản chất của họ là người làm việc miệt mài. Tuy nhiên, người sinh năm Thìn lại dễ bị stress và thỉnh thoảng phải chịu sự căng thẳng và các cơn đau đầu do những điều mạo hiểm mà họ dấn thân vào. Những người này nên thêm vào cuộc sống của họ các hoạt động ít căng thẳng hơn mà lại có thể có ích cho trí óc và cơ thể.",                                CommonName = "Sức Khỏe"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                 Genus = "Thìn",
                                ScientificName = "2015 thực sự là một năm tốt đẹp và bận rộn với những cá nhân tuổi Thìn, đặc biệt ở tháng ba, năm và bảy. Để giữ gìn thành quả của mình, sự quyết tâm, nỗ lực rất cần thiết, bởi ngay cả khi bạn đang ở một vị trí nào đó đã nhiều năm, nhưng sự thay đổi, tái cấu trúc tổng thể nào đó có thể khiến công việc của bạn bị ảnh hưởng. Tính đến những bước đi mới chủ động và vạch ra những mục tiêu cụ thể là cách để bạn vững vàng trong cuộc sống. Đây cũng là năm mà cơ hội kiếm tiền nhiều hơn, giúp bạn tăng doanh thu. May mắn hơn cả là bạn không bị hao hụt tiền của vì những rắc rối bất ngờ, hãy tận dụng để tích cóp, không nên tiêu xài hoang phí.Người tuổi Thìn là những người lãnh đạo và họ thích được như vậy. Họ không hề thiếu tự tin và rất giỏi trong việc khai thác trí thông minh, tài năng và năng lượng. Kỹ năng phi thường này tạo ra nhiều cơ hội cho họ đạt được những điều tuyệt vời. Các công việc cho phép vận dụng khả năng sáng tạo đều phù hợp với họ.",
                                CommonName = "Sự nghiệp và tài chính"
                            },
                             new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                 Genus = "Thìn",
                                ScientificName = "Trong chuyện tình cảm, Rồng không dễ dàng đánh đổi tình yêu lấy sự tự do mà họ có. Dễ nổi nóng, bạn chỉ thực sự hạnh phúc khi tìm thấy một nửa kiên nhẫn và dịu dàng. Với người mình thực sự yêu thương, Rồng sẽ không ngại hy sinh bản thân mình.",
                                CommonName = "Tình duyên"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Thìn",
                                ScientificName = "Người tuổi Thìn hợp với tuổi Thân, tuổi Tí và tuổi Tỵ..",
                                CommonName = "Hợp tuổi"
                            },

                            //Mui:
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Mùi",
                                ScientificName = "Năm sinh: 1919, 1931, 1943, 1955, 1967, 1979, 1991, 2003, 2015, 2027. Màu may mắn: Xanh, đỏ, tía. Số may mắn: 2, 7. Hoa may mắn: Cẩm chướng",
                                CommonName = "Nhận dạng các cá nhân tuổi Mùi:"
                            },
                              new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Mùi",
                                ScientificName = "Nằm ở vị trí thứ 8 trong bảng xếp hạng 12 con giáp là các cá nhân tuổi Mùi – những con người kiểu cách, nhạy cảm và đáng tin cậy. Họ điềm tĩnh, thông minh và luôn đầy sức hút trong mắt tập thể. Sống hướng nội, họ thực sự hạnh phúc khi ở bên gia đình và thường không bị cảm giác cô đơn dù chẳng có ai bên cạnh. Chưa bao giờ Dê hứng thú với việc tìm kiếm vị trí trung tâm, bởi họ yêu thích những chốn yên tĩnh – nơi họ có thể suy nghĩ về cuộc sống một cách thanh thản. 2015 là năm mà bạn có nhiều vấn đề cần phải quan tâm giải quyết, đặc biệt trong sự nghiệp, tài chính. Một vài thay đổi đáng kể (có thể liên quan tới vị trí làm việc hiện nay) đòi hỏi bạn sự điềm tĩnh và vững vàng. Để phòng xa cho những ngày khó khăn, đừng quên chi tiêu tiết kiệm, tránh cho vay mượn. Một vài dấu hiệu cho thấy bạn có thể bị lỗ nếu kinh doanh không thận trọng. Trước mọi tình huống xấu, hãy giữ tinh thần lạc quan rằng những điều khó khăn nhất rồi cũng qua đi. Điều quan trọng, bạn có được những bài học quý giá về cuộc sống, tình bạn, tình yêu và tìm thấy đáp án cho câu trả lời: Ai mới là người mình có thể tin tưởng.Thời điểm giữa cho đến cuối năm, tình hình sẽ trở nên khả quan hơn, đặc biệt liên quan tới thu nhập. Tăng tốc và nỗ lực cống hiến cho công việc, bạn sẽ gặt hái nhiều thành quả giá trị. Những vấn đề rắc rối tưởng chừng không thể tháo gỡ được trong những ngày đầu năm sẽ tự khắc được xử lý. Ngoài ra, đây cũng là năm mà Dê nên sống kín tiếng, tập trung vào công việc của mình và tránh sự thay đổi. Bạn cũng không nên đi du lịch (nhất là những chuyến du lịch dài này), hạn chế dự tang ma, thay đổi nhà cửa, phòng ốc… Trong mọi vấn đề, hãy thầm lặng hành động thay vì thể hiện mình và gây sự chú ý không cần thiết, có thể mang lại những tác hại cho bạn.",
                                CommonName = "Bảng tương hợp, tương khắc của các cá nhân tuổi Mùi:"
                            },
                            new MobileInformation
                            {
                                Family ="",
                                Subfamily = "",
                                Genus = "Mùi",
                                ScientificName = "Một người sinh vào năm Mùi được nhắc đến nhiều ở khía cạnh nghệ thuật với tài năng tuyệt vời trong những nỗ lực sáng tạo. Người tuổi Mùi có mắt thẩm mỹ và có năng khiếu về thời trang. Đồng thời họ cũng là người chu đáo. Họ luôn cẩn thận để không làm tổn thương bất kỳ ai, và nếu phải làm thế thì họ cũng sẽ giải quyết lại tình huống đó. Trên hết, người sinh năm Mùi là người được bạn bè ngưỡng mộ và dễ hòa đồng. Những người tuổi Mùi thích tận hưởng cảm giác thoải mái khi có những người bạn thân thiết và các mối quan hệ thân thiện trong công việc. Mặc dù không phải sinh ra để làm lãnh đạo nhưng họ có những ý kiến thông minh và tinh thần sẵn sàng sẻ chia, góp phần vào sự thành công cho tập thể – đây là điều khiến họ trở nên một thành viên tuyệt vời của nhóm. Người tuổi Mùi sẽ luôn luôn tìm kiếm sự đồng thuận, đặc biệt là từ những người mà họ tôn trọng. Suốt cuộc đời mình, họ sẽ cần được thúc bách liên tục và cần đến sự hỗ trợ mạnh mẽ từ phía gia đình và bạn bè. Nếu bạn sinh vào những năm dưới đây thì bạn là người tuổi Mùi. Năm Mùi: 1919, 1931, 1943, 1955, 1967, 1979, 1991, 2003",
                                CommonName = "Bản chất"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Mùi",
                                ScientificName = "Bận rộn với guồng quay công việc, tiền bạc, bạn có thể xao lãng chăm sóc bản thân. Vì đây là năm mà bạn di chuyển nhiều, hãy thận trọng khi tham gia giao thông, tránh sinh hoạt thiếu điều độ. Đây cũng là năm mà sao xấu ảnh hưởng tới những người thân trong gia đình bạn, đặc biệt là người lớn tuổi. Nhìn chung, người sinh năm Mùi có xu hướng ít gặp các vấn đề về sức khỏe, có lẽ bởi vì họ là người hiền lành. Họ có thể có vẻ bề ngoài mong manh, nhưng đừng để điều đó đánh lừa bạn, họ là tuýp người tiêu biểu cho sự khỏe mạnh. Tuy nhiên, nỗi buồn sẽ làm những người tuổi Mùi thấy suy sụp. Khi họ vui vẻ thì họ khỏe mạnh, nhưng khi họ buồn thì họ sẽ lâm bệnh ngay.",
                                CommonName = "Sức Khỏe"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                 Genus = "Mùi",
                                ScientificName = "Những rắc rối xảy đến trong công việc có thể khiến bạn có một khởi đầu không mấy dễ chịu. Tuy nhiên, sau những biến động, khoảng thời gian giữa tới cuối năm báo hiệu sự bận rộn, bạn di chuyển liên tục, thậm chí có thể thay đổi địa điểm sống. Nếu bạn có thể năng động, nhiệt tình cống hiến, bạn sẽ được ghi nhận và có cơ hội thăng tiến. Đối với những người tuổi Mùi thì quyền lực và địa vị không quan trọng. Họ thích là một phần của tập thể hơn, nhưng sẽ đảm nhận vai trò lãnh đạo nếu được yêu cầu trực tiếp.Tuy nhiên, họ lại chẳng bao giờ xung phong làm thế. Loại công việc có thể phát huy tính sáng tạo sẽ đem lại thành công cho những người tuổi Mùi.",
                                CommonName = "Sự nghiệp và tài chính"
                            },
                            new MobileInformation
                            {
                                Family = "",
                                Subfamily = "",
                                Genus = "Mùi",
                                ScientificName = "Người tuổi Sửu hạp với người tuổi Tỵ, tuổi Dậu và tuổi Tý.",
                                CommonName = "Hợp tuổi"
                            }
                        }
                    );
        }
    }
}