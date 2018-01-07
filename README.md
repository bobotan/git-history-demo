# Git 历史记录演示程序

常见场景

* 你正在开发一个网站的某个新功能，按照Git的推荐方式，你创建了feature1分支来承载这个新功能的代码变更。
* 当你已经在这个功能上完成几次代码提交的时候，你的项目经理告诉你这个网站现在出现了一个严重的线上问题，需要紧急修复。
* 为了能够快速修复这个线上问题，你不能等待下一个版本发布，必须在现有线上版本上进行修复。这时你暂停了feature1分支的开发工作，切换回到master分支，从新拉取一个名为hotfix的分支并在这个分支上开始了线上问题的修复。
* 当你完成了修复并测试通过后，你将hotfix分支合并到master以便立即修复线上版本。
* 完成以上工作后，你切换回到feature1分支继续进行新功能的开发直到新的功能也经过测试可以发布。
最后你将feature1分支也合并回到master分支，发布到线上环境。