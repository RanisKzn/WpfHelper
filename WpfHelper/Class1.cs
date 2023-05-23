using System;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace WpfHelper
{
    public class WpfHelper
    {
        //private void SaveBTN_Click(object sender, RoutedEventArgs e)
        //{
        //    using (PopryzhenokDBEntities popryzhenokDBEntities = new PopryzhenokDBEntities())
        //    {
        //        var agent = (Agent)AgentCard.DataContext;
        //        agent.AgentTypeID = ((AgentsType)TypeCB.SelectedItem).AgentTypeID;
        //        popryzhenokDBEntities.Agent.AddOrUpdate(agent);
        //        popryzhenokDBEntities.SaveChanges();
        //        MessageBox.Show("Norm");
        //    }
        //}
        public void Save()
        {

        }
        //private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        //{
        //    using (PopryzhenokDBEntities popryzhenokDBEntities = new PopryzhenokDBEntities())
        //    {
        //        var id = ((Agent)AgentCard.DataContext).AgentId;
        //        popryzhenokDBEntities.Agent.Remove(popryzhenokDBEntities.Agent.Where(x => x.AgentId == id).FirstOrDefault());
        //        popryzhenokDBEntities.SaveChanges();
        //        MessageBox.Show("Norm");
        //        MainWindow mainWindow = new MainWindow();
        //        this.Close();
        //        mainWindow.Show();
        //    }
            //string messageBoxText = $"Вы правда хотите удалить этот {service.ServiceName} объект?";
            //string caption = "Word Processor";
            //MessageBoxButton button = MessageBoxButton.YesNoCancel;
            //MessageBoxImage icon = MessageBoxImage.Warning;
            //MessageBoxResult result;
            //result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
               
        //if (result == MessageBoxResult.Yes)
        //{
        //    using (OnlineSchoolEntities1 context = new OnlineSchoolEntities1())
        //    {
        //        context.Service.Remove(service);
        //        context.SaveChanges();
        //    }
        //}
//}
public void Delete()
        {

        }

        //public ChangeAgentWindow(Agent agent)
        //{
        //    InitializeComponent();
        //    AgentCard.DataContext = agent;
        //    TypeCB.ItemsSource = context.AgentsType.ToList();
        //    TypeCB.SelectedItem = ((List<AgentsType>)TypeCB.ItemsSource).Find(x => x.AgentTypeID == agent.AgentTypeID);
        //    var consistAgent = context.ProductSale.Where(x => x.AgentId == agent.AgentId).FirstOrDefault();
        //    if (consistAgent != null)
        //    {
        //        DeleteBTN.Visibility = Visibility.Hidden;

        //    }
        //FiterCB.ItemsSource = new List<String>() 
        //{ 
        //    "Все","0 - 5%", "5% - 15%", "15% - 30%", "30% - 70%", "70% - 100%" 
        //};
        //SortderCB.ItemsSource = new List<String>() 
        //{ 
        //    "По возромтанию","По убыванию"
        //};
//}
public void Change()
        {

        }

        //private void setItemSource()
        //{
        //    var agents = this.agents;
        //    var filteredAgents = getByfilter(agents);
        //    var searchedAgents = getBySearch(filteredAgents);
        //    var sortedAgents = getBySorted(searchedAgents);
        //    AgentList.ItemsSource = sortedAgents;


        //}
        //private List<Agent> getByfilter(List<Agent> agents)
        //{
        //    if (FilterCB.SelectedIndex == 0)
        //    {
        //        agents = context.Agent.ToList();
        //    }
        //    else
        //    {
        //        agents = context.Agent.Where(x => x.AgentsType.Name == ((AgentsType)FilterCB.SelectedItem).Name).ToList();
        //    }
        //    return agents;
        //}
        //private List<Agent> getBySearch(List<Agent> agents)
        //{

        //    if (String.IsNullOrEmpty(SearchTB.Text))
        //    {
        //        return agents;
        //    }
        //    else
        //    {

        //        agents = agents.Where(x => x.AgentName.Contains(SearchTB.Text) || x.Phone.Contains(SearchTB.Text) || x.Email.Contains(SearchTB.Text)).ToList();
        //    }
        //    return agents;
        //}
        //private List<Agent> getBySorted(List<Agent> agents)
        //{

        //    switch (SorterCB.SelectedIndex)
        //    {
        //        case 0:
        //            agents = agents.OrderBy(x => x.AgentName).ToList();
        //            break;
        //        case 1:
        //            agents = agents.OrderByDescending(x => x.AgentName).ToList();
        //            break;
        //        case 2:
        //            agents = agents.OrderBy(x => x.Sale).ToList();
        //            break;
        //        case 3:
        //            agents = agents.OrderByDescending(x => x.Sale).ToList();
        //            break;
        //        case 4:
        //            agents = agents.OrderBy(x => x.Priority).ToList();
        //            break;
        //        case 5:
        //            agents = agents.OrderByDescending(x => x.Priority).ToList();
        //            break;
        //        default:
        //            agents = agents.ToList();
        //            break;
        //    }
        //    return agents;
        //}
        public void setItemSource()
        {

        }

        //if ((sender as Grid).DataContext is Agent agent)
        //{
        //    ChangeAgentWindow changeAgentWindow = new ChangeAgentWindow(agent);
        //    this.Close();
        //    changeAgentWindow.Show();
        //}
        public void GridClick()
        {

        }
        //xmlns:system="clr-namespace:System;assembly=mscorlib"
    //    <Window.Resources>
    //    <system:String x:Key="NullImage">
    //        pack://application:,,,/Resources/picture.png
    //    </system:String>
    //</Window.Resources>
    //<Grid Background = "#43DCFE" >
    //    < Grid.RowDefinitions >
    //        < RowDefinition Height="*"></RowDefinition>
    //        <RowDefinition Height = "6*" ></ RowDefinition >
    //        < RowDefinition Height="*"></RowDefinition>
    //    </Grid.RowDefinitions>
    //    <Grid.ColumnDefinitions>
    //        <ColumnDefinition Width = "*" ></ ColumnDefinition >
    //        < ColumnDefinition Width="*"></ColumnDefinition>
    //    </Grid.ColumnDefinitions>
    //    <Image VerticalAlignment = "Top" HorizontalAlignment="Left" Source="Resources/Попрыженок.png"></Image>
    //    <TextBox x:Name="SearchTB" Width="250" Height="30" TextChanged="SearchTB_TextChanged"></TextBox>
    //    <UniformGrid Grid.Row="0" Grid.Column= "1" Rows= "1" >
    //        < ComboBox Name= "SorterCB" Width= "150" Height= "30" SelectionChanged= "SorterCB_SelectionChanged" ></ ComboBox >
    //        < ComboBox Name= "FilterCB" Width= "150" Height= "30" SelectionChanged= "FilterCB_SelectionChanged" DisplayMemberPath= "Name" ></ ComboBox >
    //    </ UniformGrid >
    //    < ListView Name= "AgentList" Grid.Row= "1" Grid.ColumnSpan= "2" ScrollViewer.HorizontalScrollBarVisibility= "Disabled" SelectionChanged= "AgentList_SelectionChanged" >
    //        < ListView.ItemsPanel >
    //            < ItemsPanelTemplate >
    //                < WrapPanel >


    //                </ WrapPanel >
    //            </ ItemsPanelTemplate >
    //        </ ListView.ItemsPanel >
    //        < ListView.ItemTemplate >
    //            < DataTemplate >
    //                < Border BorderBrush= "Black" BorderThickness= "1" >
    //                    < Grid Width= "800" MouseRightButtonDown= "Grid_MouseRightButtonDown" Background= "{Binding DisplayColor}" >
    //                        < Grid.RowDefinitions >
    //                            < RowDefinition Height= "*" ></ RowDefinition >
    //                            < RowDefinition Height= "*" ></ RowDefinition >
    //                            < RowDefinition Height= "*" ></ RowDefinition >
    //                            < RowDefinition Height= "*" ></ RowDefinition >
    //                        </ Grid.RowDefinitions >
    //                        < Grid.ColumnDefinitions >
    //                            < ColumnDefinition Width= "*" ></ ColumnDefinition >
    //                            < ColumnDefinition Width= "4*" ></ ColumnDefinition >
    //                            < ColumnDefinition Width= "*" ></ ColumnDefinition >
    //                            < ColumnDefinition Width= "*" ></ ColumnDefinition >
    //                        </ Grid.ColumnDefinitions >
    //                        < Image Grid.Column= "0" Grid.RowSpan= "4" Width= "100" Source= "{Binding LogoDisplay, FallbackValue={StaticResource NullImage}}" ></ Image >
    //                        < TextBlock Grid.Row= "0" Grid.Column= "1" Text= "{Binding TypeAndName}"  Width= "auto" >
    //                            </ TextBlock >
    //                            < TextBlock Name= "ProdaziTB" Text= "{Binding Prodaji}" Grid.Row= "1" Grid.Column= "1" ></ TextBlock >
    //                        < TextBlock Text= "{Binding Phone}" Grid.Row= "2" Grid.Column= "1" ></ TextBlock >
    //                        < TextBlock Text= "{Binding Priority}" Grid.Row= "3" Grid.Column= "1" ></ TextBlock >
    //                        < TextBlock Text= "{Binding SaleValue}" Grid.RowSpan= "4" Grid.Column= "3" FontSize= "24" ></ TextBlock >
    //                    </ Grid >
    //                </ Border >
    //            </ DataTemplate >
    //        </ ListView.ItemTemplate >
    //    </ ListView >
    //    < UniformGrid Grid.Row= "4" Grid.ColumnSpan= "2" Rows= "1" >
    //        < Button Name= "ChangePriorityBTN" Content= "Измениить приоритет на " Visibility= "Hidden" Width= "150" Height= "30"  Click= "ChangePriorityBTN_Click" ></ Button >
    //        < Button Background= "#F9969E" Name= "AddAgentBTN" Content= "Добавить агента" Width= "150" Height= "30" Click= "AddAgentBTN_Click" ></ Button >
    //    </ UniformGrid >
    //</ Grid >
        public void RazmetcaMain()
        {

        }
    //    <Grid Name = "AgentCard" >
    //    < Grid.ColumnDefinitions >
    //        < ColumnDefinition Width="*"></ColumnDefinition>
    //        <ColumnDefinition Width = "*" ></ ColumnDefinition >
    //    </ Grid.ColumnDefinitions >
    //    < Grid.RowDefinitions >
    //        < RowDefinition Height="*"></RowDefinition>
    //        <RowDefinition Height = "*" ></ RowDefinition >
    //        < RowDefinition Height="*"></RowDefinition>
    //        <RowDefinition Height = "*" ></ RowDefinition >
    //        < RowDefinition Height="*"></RowDefinition>
    //        <RowDefinition Height = "*" ></ RowDefinition >
    //        < RowDefinition Height="*"></RowDefinition>
    //        <RowDefinition Height = "*" ></ RowDefinition >
    //        < RowDefinition Height="*"></RowDefinition>
    //        <RowDefinition Height = "*" ></ RowDefinition >
    //    </ Grid.RowDefinitions >
    //    < UniformGrid Grid.Row="9" Grid.ColumnSpan="2" Rows="1" >
    //        <Button x:Name="BackBTN" Height="30" Width="150" Content="Назад" Click="BackBTN_Click"></Button>
    //        <Button x:Name="SaveBTN" Height="30" Width="150" Content="Сохранить" Click="SaveBTN_Click" ></Button>
    //    </UniformGrid>
    //    <TextBlock x:Name="TextBlockName" Text="Наименование" VerticalAlignment="Center" HorizontalAlignment="Right" Margin="10" ></TextBlock>
    //    <TextBox x:Name="NameTB" Text="{Binding AgentName}" Grid.Row="0" Grid.Column="1" Height="30" Width="300" VerticalAlignment="Center" HorizontalAlignment="Left" Margin="10"></TextBox>

    //    <TextBlock x:Name="TextBlockType" Grid.Row="1"  Text="Тип агента" VerticalAlignment="Center" HorizontalAlignment="Right" Margin="10"></TextBlock>
    //    <ComboBox x:Name="TypeCB" Grid.Row="1" DisplayMemberPath="Name" Grid.Column="1" Height="30" Width="300" VerticalAlignment="Center" HorizontalAlignment="Left" Margin="10"></ComboBox>

    //    <TextBlock x:Name="TextBlockPriority" Grid.Row="2"  Text="Приоритет" VerticalAlignment="Center" HorizontalAlignment="Right" Margin="10"></TextBlock>
    //    <TextBox x:Name="PriorityTB" Text="{Binding Priority}"  Grid.Row="2" Grid.Column="1" Height="30" Width="300" VerticalAlignment="Center" HorizontalAlignment="Left" Margin="10"></TextBox>

    //    <TextBlock x:Name="TextBlockAddres" Grid.Row="3"  Text="Аддрес" VerticalAlignment="Center" HorizontalAlignment="Right" Margin="10"></TextBlock>
    //    <TextBox x:Name="AddresTB" Text="{Binding YridAddres}"  Grid.Row="3" Grid.Column="1" Height="30" Width="300" VerticalAlignment="Center" HorizontalAlignment="Left" Margin="10"></TextBox>

    //    <TextBlock x:Name="TextBlockINN" Text="ИНН" Grid.Row="4"  VerticalAlignment="Center" HorizontalAlignment="Right" Margin="10"></TextBlock>
    //    <TextBox x:Name="INNTB" Grid.Row="4" Text="{Binding INN}" Grid.Column="1" Height="30" Width="300" VerticalAlignment="Center" HorizontalAlignment="Left" Margin="10"></TextBox>

    //    <TextBlock x:Name="TextBlockCPP" Text="КПП" Grid.Row="5" VerticalAlignment="Center" HorizontalAlignment="Right" Margin="10"></TextBlock>
    //    <TextBox x:Name="CPPTB" Text="{Binding CPP}" Grid.Row="5" Grid.Column="1" Height="30" Width="300" VerticalAlignment="Center" HorizontalAlignment="Left" Margin="10"></TextBox>

    //    <TextBlock x:Name="TextBlockDirector" Grid.Row="6" Text="ФИО Директора" VerticalAlignment="Center" HorizontalAlignment="Right" Margin="10"></TextBlock>
    //    <TextBox x:Name="DirectorTB" Text="{Binding DirectorFIO}" Grid.Row="6" Grid.Column="1" Height="30" Width="300" VerticalAlignment="Center" HorizontalAlignment="Left" Margin="10"></TextBox>

    //    <TextBlock x:Name="TextBlockPhone" Grid.Row="7" Text="Телефон" VerticalAlignment="Center" HorizontalAlignment="Right" Margin="10"></TextBlock>
    //    <TextBox x:Name="PhoneTB" Text="{Binding Phone}"  Grid.Row="7" Grid.Column="1" Height="30" Width="300" VerticalAlignment="Center" HorizontalAlignment="Left" Margin="10"></TextBox>

    //    <TextBlock x:Name="TextBlockEmail"  Grid.Row="8" Text="Почта" VerticalAlignment="Center" HorizontalAlignment="Right" Margin="10"></TextBlock>
    //    <TextBox x:Name="EmailTB" Text="{Binding Email}" Grid.Row="8" Grid.Column="1" Height="30" Width="300" VerticalAlignment="Center" HorizontalAlignment="Left" Margin="10"></TextBox>
    //</Grid>

    public void RazmetcaChange()
    {

    }

    //private int _tickCounter = 0;
    //private int _refreshTime = 30;
    //public UpcomingRecordWindow()
    //{
    //    InitializeComponent();
    //    GetClientServices();


    //    var timer = new DispatcherTimer();
    //    timer.Tick += Timer_Tick;
    //    timer.Interval = TimeSpan.FromSeconds(1);
    //    timer.Start();
    //}

    //private void Timer_Tick(object sender, EventArgs e)
    //{
    //    _tickCounter++;
    //    if (_tickCounter % _refreshTime == 0)
    //    {
    //        GetClientServices();
    //    }
    //}
    //private void GetClientServices()
    //{
    //    recordList = onlineSchool.Record.ToList();
    //    RecordsList.ItemsSource = recordList;

    //    recordList = recordList.OrderByDescending(c => c.StartDate).ToList();
    //}

    public void Timer()
    {

    }
    }
}