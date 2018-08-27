# Map4Students
<Page x:Class="Map4Students.Page1" 
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"  
      xmlns:d="http://schemas.microsoft.com/expression/blend/2008"  
      xmlns:local="clr-namespace:Map4Students" 
      mc:Ignorable="d"  
      Title="Page1" Height="1000" Width="1500"> 
      
    <Grid> 
        <Grid.RowDefinitions> 
            <RowDefinition Height="22.5"/> 
            <RowDefinition Height="190"/> 
            <RowDefinition Height="190"/> 
            <RowDefinition Height="190"/> 
            <RowDefinition Height="190"/> 
            <RowDefinition Height="190"/> 
            <RowDefinition Height="180"/> 
        </Grid.RowDefinitions> 
        
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="500"> 
            </ColumnDefinition> 
            <ColumnDefinition Width="500"> 
            </ColumnDefinition>
            <ColumnDefinition Width="500"> 
            </ColumnDefinition> 
        </Grid.ColumnDefinitions> 
        
        <!--CCGS SYMBOL--> 
        <Image Grid.Column="0" Grid.Row="1" Grid.RowSpan="3" Source="CCGS-logo-1.jpg" Margin="0,22,0,0.5"/> 

        <!--Student NUmber-->  
        <TextBlock Grid.Row="1" Grid.Column="1" Grid.ColumnSpan="2" FontSize="72" Foreground="Black" Margin="125,189.5,-25,79.5" Grid.RowSpan="2">Student Number</TextBlock> 

        <Border MinWidth="250" Background="Orange" BorderBrush="Black" BorderThickness="1" HorizontalAlignment="Center" VerticalAlignment="Bottom" Grid.Row="2" Grid.Column="1" Grid.ColumnSpan="2" Margin="125,0,240,116.5" Width="635" Height="148" Grid.RowSpan="2"> 
            <StackPanel> 
                <TextBox Width="500" HorizontalAlignment="Center" VerticalAlignment="Center" x:Name="InputTextBox" Margin="66,25,67,0" Height="34" FontSize="18"/> 
                <StackPanel Orientation="Horizontal" HorizontalAlignment="Center"> 
                    <Button x:Name="Login_Page_Enter_Button" Margin="200,10,0,5" Content="Enter" Click="buttonclick1" Height="61" Width="274" RenderTransformOrigin="0.967,1.557" FontSize="18"/> 
                </StackPanel>
            </StackPanel> 
        </Border> 
    </Grid> 
</Page>
